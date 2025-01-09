using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SleepHealthcare.API.Data.Models
{
    public class Refund
    {
        [Key]
        [Column("refund_id")]
        [StringLength(15)]
        public string RefundId { get; set; } = string.Empty;

        [Column("bill_id")]
        [StringLength(15)]
        public string? BillId { get; set; }

        [Column("payment_type")]
        [StringLength(50)]
        public string? PaymentType { get; set; }

        [Column("reason")]
        [StringLength(150)]
        public string? Reason { get; set; }

        [Column("amount")]
        public int? Amount { get; set; }

        [Column("date")]
        public DateTime? Date { get; set; }
    }
}
