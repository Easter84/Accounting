using Accounting.Models;
using Accounting.Views;

namespace Accounting
{
    public partial class MainForm : Form
    {
        private int _totalWidth = 0;
        private double _amountPaid = 0;

        public MainForm()
        {
            this.InitializeComponent();
            LoadDebtors();
        }

        private void LoadIncomes()
        {
            incomeDataGrid.BackgroundColor = Color.White;
            try
            {
                var incomeRepo = new IncomeQueries(new DatabaseHelper());
                List<Income> incomes = incomeRepo.GetAllIncomes();

                if (incomes.Count > 0)
                {
                    incomeDataGrid.AutoGenerateColumns = true;
                    incomeDataGrid.DataSource = incomes;

                    incomeDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    foreach (DataGridViewColumn column in incomeDataGrid.Columns)
                    {
                        _totalWidth += column.Width;
                    }

                    incomeDataGrid.Columns["Income_id"].Visible = false;
                    incomeDataGrid.Columns["Ledgers"].Visible = false;
                    incomeDataGrid.Columns["income_source"].HeaderText = "Company";
                    incomeDataGrid.Columns["income_amount"].HeaderText = "Amount";
                    incomeDataGrid.Columns["pay_date"].HeaderText = "Date Paid";
                }
                else
                {
                    MessageBox.Show("No Income Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Loading Income: {ex.Message}");
            }
        }

        private void LoadLedger()
        {
            balanceDataGrid.BackgroundColor = Color.White;
            try
            {
                var ledgerRepo = new LedgerQueries(new DatabaseHelper());
                List<Ledger> ledgers = ledgerRepo.GetAllLedgers();
                if (ledgers.Count > 0)
                {
                    balanceDataGrid.AutoGenerateColumns = true;
                    balanceDataGrid.DataSource = ledgers;

                    balanceDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    foreach (DataGridViewColumn column in balanceDataGrid.Columns)
                    {
                        _totalWidth += column.Width;
                    }

                    // Adjusting the Column displays and setting their Alias
                    balanceDataGrid.Columns["id"].Visible = false;
                    balanceDataGrid.Columns["debtor_id"].Visible = false;
                    balanceDataGrid.Columns["Debtor"].Visible = false;
                    balanceDataGrid.Columns["income_id"].Visible = false;
                    balanceDataGrid.Columns["Income"].Visible = false;
                    balanceDataGrid.Columns["trans_date"].HeaderText = "Date";
                    balanceDataGrid.Columns["payment"].HeaderText = "Payment";
                    balanceDataGrid.Columns["balance"].HeaderText = "Balance";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading balance: {ex.Message}");
            }
        }

        private void LoadDebtors()
        {
            debtorsDataGrid.BackgroundColor = Color.White;
            try
            {
                var debtorRepo = new DebtorQueries(new DatabaseHelper());
                List<Debtor> debtors = debtorRepo.GetDebtorList();

                debtorsDataGrid.DataSource = null;

                if (debtors.Count > 0)
                {
                    debtorsDataGrid.AutoGenerateColumns = true;
                    debtorsDataGrid.DataSource = debtors;

                    debtorsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    foreach (DataGridViewColumn column in debtorsDataGrid.Columns)
                    {
                        _totalWidth += column.Width;
                    }

                    debtorsDataGrid.Columns["debtor_id"].Visible = false;
                    debtorsDataGrid.Columns["Ledgers"].Visible = false;
                    debtorsDataGrid.Columns["debtor_name"].HeaderText = "Company";
                    debtorsDataGrid.Columns["amount_due"].HeaderText = "Amount Due";
                    debtorsDataGrid.Columns["due_date"].HeaderText = "Due Date";
                    debtorsDataGrid.Columns["is_paid"].HeaderText = "Paid";
                }
                else
                {
                    MessageBox.Show("No debtors found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Bills: {ex.Message}");
            }
        }

        private void AddBill_Click(object sender, EventArgs e)
        {
            // Creating an new instance of the AddDebtorview
            AddDebtorView newDebtor = new AddDebtorView();

            // If the form was closed with a OK result capture its data
            if (newDebtor.ShowDialog() == DialogResult.OK)
            {
                string debtorName = newDebtor.DebtorName;
                double amountDue = newDebtor.AmountDue;
                string dateDue = newDebtor.DueDate;

                MessageBox.Show($"Debtor: {debtorName}, Amount Due: {amountDue}");
                // Reload the DataGrid
                LoadDebtors();
            }
        }

        private void addIncome_Click(object sender, EventArgs e)
        {
            // Launch the Income Form
            AddIncomeForm addIncome = new AddIncomeForm();
            if (addIncome.ShowDialog() == DialogResult.OK)
            {
                int incomeID = addIncome.IncomeID;
                double incomeAmount = addIncome.IncomeAmount;
                updateLedgerIncome(incomeAmount, incomeID);
                LoadIncomes();
            }
        }

        private void viewTabControl_Click(object sender, EventArgs e)
        {
            if (viewTabControl.SelectedIndex == 0)
            {
                LoadDebtors();
            }
            else if (viewTabControl.SelectedIndex == 1)
            {
                LoadIncomes();
            }
            else if (viewTabControl.SelectedIndex == 2)
            {
                LoadLedger();
            }
            else
            {
                //do_nothing();
            }
        }

        private void debtorsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var recordID = debtorsDataGrid.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? "No Data";
                var companyName = debtorsDataGrid.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? "No Data";
                var amountDue = debtorsDataGrid.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? "No Data";
                var isPaid = debtorsDataGrid.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? "No Data";
                var dueDate = debtorsDataGrid.Rows[e.RowIndex].Cells[4].Value?.ToString() ?? "No Data";

                PayBill payBill = new PayBill(recordID, companyName, amountDue, isPaid, dueDate);
                if (payBill.ShowDialog() == DialogResult.OK)
                {
                    _amountPaid = payBill.amountPaid;
                    updateLedgerPayment(_amountPaid, Convert.ToInt16(recordID));
                }
                LoadDebtors();
            }
        }

        private void updateLedgerPayment(double amountPaid, int debtorID)
        {
            var ledgerRepo = new LedgerQueries(new DatabaseHelper());
            Ledger lastEntry = ledgerRepo.GetLastEntry();

            double newBalance;

            if (lastEntry != null)
            {
                double startBalance = Convert.ToDouble(lastEntry.balance);
                newBalance = startBalance - amountPaid;
            }
            else
            {
                newBalance = -amountPaid;
            }

            Ledger ledger = new Ledger
            {
                trans_date = DateTime.Now.ToString("yyyy-MM-dd"),
                payment = amountPaid,
                balance = newBalance,
                debtor_id = debtorID,
            };

            ledgerRepo.AddLedger(ledger);
        }

        private void updateLedgerIncome(double amountPaid, int incomeID)
        {
            var ledgerRepo = new LedgerQueries(new DatabaseHelper());
            Ledger lastEntry = ledgerRepo.GetLastEntry();

            double newBalance;

            if (lastEntry != null)
            {
                double startBalance = Convert.ToDouble(lastEntry.balance);
                newBalance = startBalance + amountPaid;
            }
            else
            {
                newBalance = +amountPaid;
            }

            Ledger ledger = new Ledger
            {
                trans_date = DateTime.Now.ToString("yyyy-MM-dd"),
                payment = amountPaid,
                balance = newBalance,
                income_id = incomeID,
            };

            ledgerRepo.AddLedger(ledger);
        }
    }
}
