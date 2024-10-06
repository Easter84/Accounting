using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Models
{
    [Table("income")]
    public class Income
    {
        [Key]
        public int income_id { get; set; }
        public string income_source { get; set; }
        public double income_amount { get; set; }
        public string pay_date { get; set; }

        public ICollection<Ledger> Ledgers { get; set; }
    }
}
