namespace Accounting.Models
{
    public class IncomeQueries
    {
        private readonly DatabaseHelper _databaseHelper;

        public IncomeQueries(DatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }

        public void AddIncome(Income income)
        {
            _databaseHelper.Add(income);
            _databaseHelper.SaveChanges();
        }

        public void UpdateIncome(Income income)
        {
            _databaseHelper.Update(income);
            _databaseHelper.SaveChanges();
        }

        public List<Income> GetAllIncomes()
        {
            return _databaseHelper.Income.ToList();
        }
    }
}
