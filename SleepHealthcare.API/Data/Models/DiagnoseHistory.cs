using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace SleepHealthcare.API.Data.Models
{
    public class DiagnoseHistory
    {
        [Key]
        [Column("diagnostic_id")]
        [StringLength(10)]
        public string DiagnosticId { get; set; } = string.Empty;

        [Column("patient_id")]
        [StringLength(10)]
        public string? PatientId { get; set; }

        [Column("diagnose")]
        [StringLength(150)]
        public string? Diagnose { get; set; }

        [Column("date")]
        public DateTime? Date { get; set; }

        [Column("consultant_id")]
        [StringLength(10)]
        public string? ConsultantId { get; set; }

        [Column("prescription_id")]
        [StringLength(10)]
        public string? PrescriptionId { get; set; }

        // Navigation properties for foreign keys
        [ForeignKey("PatientId")]
        public virtual Patient? Patient { get; set; }

        [ForeignKey("ConsultantId")]
        public virtual Doctor? Consultant { get; set; }

        [ForeignKey("PrescriptionId")]
        public virtual Prescription? Prescription { get; set; }
    }
}
