using Accounting.Models;

namespace Accounting.Views
{
    public partial class AddIncomeForm : Form
    {
        public string IncomeName;
        public double IncomeAmount;
        public int IncomeID { get; private set; }

        public AddIncomeForm()
        {
            this.InitializeComponent();
            this.IncNameTextBox.Focus();
            this.payDateCalendar.MaxSelectionCount = 1;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.IncNameTextBox.Text = string.Empty;
            this.IncAmntTextBox.Text = string.Empty;
            this.IncNameTextBox.Focus();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            IncomeName = this.IncNameTextBox.Text;
            DateTime selectedDate = payDateCalendar.SelectionStart;
            string payDate = selectedDate.ToString("yyyy-MM-dd");

            if (Double.TryParse(this.IncAmntTextBox.Text, System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out IncomeAmount))
            {

                Income income = new Income();
                income.income_source = IncomeName;
                income.income_amount = IncomeAmount;
                income.pay_date = payDate;

                var incomeRepo = new IncomeQueries(new DatabaseHelper());
                incomeRepo.AddIncome(income);

                this.IncomeID = income.income_id;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Income must be a valid Number");
            }
        }
    }
}
