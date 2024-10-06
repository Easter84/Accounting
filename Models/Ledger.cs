using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Models
{
    [Table("ledger")]
    public class Ledger
    {
        [Key]
        public int Id { get; set; }
        public string trans_date { get; set; }
        public double payment { get; set; }
        public double balance { get; set; }

        //Foreign Key to Debtor
        public int? debtor_id { get; set; }

        [ForeignKey("debtor_id")]
        public Debtor Debtor { get; set; }

        public int? income_id { get; set; }
        [ForeignKey("income_id")]
        public Income Income { get; set; }
    }
}
