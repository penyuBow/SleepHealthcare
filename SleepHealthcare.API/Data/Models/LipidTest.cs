using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SleepHealthcare.API.Data.Models
{
    public class LipidTest
    {
        [Key]
        [Column("tst_li_id")]
        [StringLength(10)]
        public string LipidTestId { get; set; } = string.Empty;

        [Column("prescription_id")]
        [StringLength(10)]
        public string? PrescriptionId { get; set; }

        [Column("cholestrolHDL")]
        [StringLength(10)]
        public string? CholestrolHDL { get; set; }

        [Column("cholestrolLDL")]
        [StringLength(10)]
        public string? CholestrolLDL { get; set; }

        [Column("triglycerides")]
        [StringLength(10)]
        public string? Triglycerides { get; set; }

        [Column("totalCholestrolLDLHDLratio")]
        [StringLength(10)]
        public string? TotalCholestrolLDLHDLratio { get; set; }

        [Column("appointment_id")]
        [StringLength(15)]
        public string? AppointmentId { get; set; }

        [Column("date")]
        public DateTime? Date { get; set; }

        // Navigation property for the foreign key
        [ForeignKey("PrescriptionId")]
        public virtual Prescription? Prescription { get; set; }
    }
}
