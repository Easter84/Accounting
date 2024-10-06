using Accounting.Models;

namespace Accounting.Views
{
    public partial class AddDebtorView : Form
    {
        public string DebtorName { get; private set; }
        public double AmountDue { get; private set; }
        public string DueDate { get; private set; }


        public AddDebtorView()
        {
            this.InitializeComponent();
            this.billNameTextBox.Focus();
        }

        // Closes the form
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Clears all fields on the form and resets the focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            this.billNameTextBox.Text = string.Empty;
            this.amountDueTextBox.Text = string.Empty;
            this.billNameTextBox.Focus();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (!ValidateDebtorName() || !ValidateDueDate() || !ValidateAmountDue())
            {
                return;
            }
            try
            {
                // Initializing the new instance
                Debtor debtor = new Debtor
                {
                    debtor_name = DebtorName,
                    amount_due = AmountDue,
                    due_date = DueDate,
                };
                var debtorQuery = new DebtorQueries(new DatabaseHelper());
                {
                    debtorQuery.UpdateDebtor(debtor);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception data_issue)
            {
                MessageBox.Show($"Error saving Bill: {data_issue.Message}");
            }
        }

        private bool ValidateDebtorName()
        {
            DebtorName = this.billNameTextBox.Text.Trim();
            if (string.IsNullOrEmpty(DebtorName))
            {
                MessageBox.Show("Company Name cannot be empty");
                return false;
            }
            return true;
        }

        private bool ValidateDueDate()
        {
            try
            {
                DueDate = this.dueDateTimePicker.Value.ToString("yyyy-MM-dd");
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Due Date");
                return false;
            }
        }

        private bool ValidateAmountDue()
        {
            if (!double.TryParse(this.amountDueTextBox.Text, out double amountDue))
            {
                MessageBox.Show("Invalid Amount");
                return false;
            }
            AmountDue = amountDue;
            return true;
        }
    }
}
