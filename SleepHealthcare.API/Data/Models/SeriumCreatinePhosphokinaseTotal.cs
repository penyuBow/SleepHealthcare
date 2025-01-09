using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SleepHealthcare.API.Data.Models
{
    public class SeriumCreatinePhosphokinaseTotal
    {
        [Key]
        [Column("tst_SCPT_id")]
        [StringLength(10)]
        public string SCPTestTotalId { get; set; } = string.Empty;

        [Column("test_id")]
        [StringLength(10)]
        public string? TestId { get; set; }

        [Column("prescription_id")]
        [StringLength(10)]
        public string? PrescriptionId { get; set; }

        [Column("cpkTotal")]
        public int? CpkTotal { get; set; }

        [Column("appointment_id")]
        [StringLength(15)]
        public string? AppointmentId { get; set; }

        [Column("date")]
        public DateTime? Date { get; set; }

        // Navigation properties for foreign keys
        [ForeignKey("TestId")]
        public virtual LabTest? LabTest { get; set; }

        [ForeignKey("PrescriptionId")]
        public virtual Prescription? Prescription { get; set; }
    }
}
