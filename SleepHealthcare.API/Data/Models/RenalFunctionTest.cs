using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SleepHealthcare.API.Data.Models
{
    public class RenalFunctionTest
    {
        [Key]
        [Column("tst_renal_id")]
        [StringLength(10)]
        public string RenalTestId { get; set; } = string.Empty;

        [Column("prescription_id")]
        [StringLength(10)]
        public string? PrescriptionId { get; set; }

        [Column("creatinine")]
        public float? Creatinine { get; set; }

        [Column("urea")]
        public float? Urea { get; set; }

        [Column("totalBilirubin")]
        public float? TotalBilirubin { get; set; }

        [Column("directBilirubin")]
        public float? DirectBilirubin { get; set; }

        [Column("sgotast")]
        public float? SgotAst { get; set; }

        [Column("sgptalt")]
        public float? SgptAlt { get; set; }

        [Column("alkalinePhospates")]
        public float? AlkalinePhospates { get; set; }

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
