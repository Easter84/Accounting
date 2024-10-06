namespace Accounting.Models
{
    public class DebtorQueries
    {
        private readonly DatabaseHelper _databaseHelper;

        public DebtorQueries(DatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }

        public void AddDebtor(Debtor debtor)
        {
            _databaseHelper.Debtors.Add(debtor);
            _databaseHelper.SaveChanges();
        }

        public List<Debtor> GetDebtorList()
        {
            return _databaseHelper.Debtors.ToList();
        }

        public void DeleteDebtor(Debtor debtor)
        {
            _databaseHelper.Remove(debtor);
            _databaseHelper.SaveChanges();
        }

        public void UpdateDebtor(Debtor debtor)
        {
            _databaseHelper.Update(debtor);
            _databaseHelper.SaveChanges();
        }

        public void PayDebtor(Debtor debtor)
        {
            if (debtor.is_paid)
            {
                _databaseHelper.Update(debtor);
                _databaseHelper.SaveChanges();
            }
            else
            {
                MessageBox.Show("Bill already paid");
            }
        }

        public void ClearPayments(Debtor debtor)
        {
            _databaseHelper.Update(debtor);
            _databaseHelper.SaveChanges();
        }
    }
}
