using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SleepHealthcare.API.Data.Models
{
    public class PharmacyHistory
    {
        [Key]
        [Column("history_id")]
        [StringLength(15)]
        public string HistoryId { get; set; } = string.Empty;

        [Column("prescription_id")]
        [StringLength(15)]
        public string? PrescriptionId { get; set; }

        [Column("bill_id")]
        [StringLength(15)]
        public string? BillId { get; set; }

        [Column("date")]
        public DateTime? Date { get; set; }

        [Column("no_of_drugs")]
        public int? NoOfDrugs { get; set; }

        [Column("excluded")]
        [StringLength(150)]
        public string? Excluded { get; set; }
    }
}
