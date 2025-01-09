using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SleepHealthcare.API.Data.Models
{
    public class UrineFullReport
    {
        [Key]
        [Column("tst_ur_id")]
        [StringLength(10)]
        public string UrineTestId { get; set; } = string.Empty;

        [Column("prescription_id")]
        [StringLength(10)]
        public string? PrescriptionId { get; set; }

        [Column("appearance")]
        [StringLength(10)]
        public string? Appearance { get; set; }

        [Column("sgRefractometer")]
        [StringLength(10)]
        public string? SgRefractometer { get; set; }

        [Column("ph")]
        public float? Ph { get; set; }

        [Column("protein")]
        [StringLength(10)]
        public string? Protein { get; set; }

        [Column("glucose")]
        [StringLength(10)]
        public string? Glucose { get; set; }

        [Column("ketoneBodies")]
        [StringLength(10)]
        public string? KetoneBodies { get; set; }

        [Column("bilirubin")]
        [StringLength(10)]
        public string? Bilirubin { get; set; }

        [Column("urobilirubin")]
        [StringLength(10)]
        public string? Urobilirubin { get; set; }

        [Column("contrifugedDepositsphaseContrastMicroscopy")]
        [StringLength(10)]
        public string? ContrifugedDepositsPhaseContrastMicroscopy { get; set; }

        [Column("pusCells")]
        [StringLength(10)]
        public string? PusCells { get; set; }

        [Column("redCells")]
        [StringLength(10)]
        public string? RedCells { get; set; }

        [Column("epithelialCells")]
        [StringLength(10)]
        public string? EpithelialCells { get; set; }

        [Column("casts")]
        [StringLength(10)]
        public string? Casts { get; set; }

        [Column("cristals")]
        [StringLength(10)]
        public string? Cristals { get; set; }

        [Column("appointment_id")]
        [StringLength(15)]
        public string? AppointmentId { get; set; }

        [Column("date")]
        public DateTime? Date { get; set; }

        // Navigation properties for foreign keys
        [ForeignKey("PrescriptionId")]
        public virtual Prescription? Prescription { get; set; }
    }
}
