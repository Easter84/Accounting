using Accounting.Models;

namespace Accounting.Views
{
    public partial class PayBill : Form
    {
        private string recordID;
        private string companyName;
        private string amountDue;
        private string isPaid;
        private string dueDate;

        public double amountPaid;

        public PayBill(string recordID, string companyName, string amountDue, string isPaid, string dueDate)
        {
            this.InitializeComponent();
            this.recordID = recordID;
            this.companyName = companyName;
            this.amountDue = amountDue;
            this.isPaid = isPaid;
            this.dueDate = dueDate;

            this.comNameTxtBx.Text = companyName;
            this.amountDueTxtBx.Text = amountDue;
            this.dueDateTxtBx.Text = dueDate;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            var payBill = new DebtorQueries(new DatabaseHelper());
            var currentBill = new Debtor();

            currentBill.debtor_id = Convert.ToInt16(this.recordID);
            currentBill.debtor_name = this.companyName;
            currentBill.amount_due = Convert.ToDouble(this.amountDue);
            currentBill.is_paid = true;
            currentBill.due_date = this.dueDate;

            payBill.PayDebtor(currentBill);

            amountPaid = currentBill.amount_due;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            var resetBill = new DebtorQueries(new DatabaseHelper());
            var currentBill = new Debtor();

            currentBill.debtor_id = Convert.ToInt16(this.recordID);
            currentBill.debtor_name = this.companyName;
            currentBill.amount_due = Convert.ToDouble(this.amountDue);
            currentBill.is_paid = false;
            currentBill.due_date = this.dueDate;

            resetBill.ClearPayments(currentBill);
            this.Close();
        }
    }
}
