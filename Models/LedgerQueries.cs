using Microsoft.EntityFrameworkCore;

namespace Accounting.Models
{
    public class LedgerQueries
    {
        private readonly DatabaseHelper _databaseHelper;

        public LedgerQueries(DatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }

        public void AddLedger(Ledger ledger)
        {
            _databaseHelper.Ledgers.Add(ledger);
            _databaseHelper.SaveChanges();
        }

        public List<Ledger> GetAllLedgers()
        {
            var ledgers = _databaseHelper.Ledgers.ToList();
            return ledgers;
        }

        public Ledger GetLastEntry()
        {
            var lastEntry = _databaseHelper.Ledgers
                .Include(l => l.Debtor)
                .OrderByDescending(l => l.Id)
                .FirstOrDefault();

            return lastEntry;
        }
    }
}