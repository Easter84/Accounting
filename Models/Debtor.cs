using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Models
{
    [Table("debtors")]
    public class Debtor
    {
        [Key]
        public int debtor_id { get; set; }
        public string debtor_name { get; set; }
        public double amount_due { get; set; }
        public bool is_paid { get; set; }
        public string due_date { get; set; }

        public ICollection<Ledger> Ledgers { get; set; }
    }
}
