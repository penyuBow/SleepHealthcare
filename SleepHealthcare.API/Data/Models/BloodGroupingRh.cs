using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SleepHealthcare.API.Data.Models
{

    public class BloodGroupingRh
    {
        [Key]
        [Column("tst_bloodG_id")]
        [StringLength(10)]
        public string BloodGroupingId { get; set; } = string.Empty;

        [Column("prescription_id")]
        [StringLength(10)]
        public string? PrescriptionId { get; set; }

        [Column("bloodGroup")]
        [StringLength(10)]
        public string? BloodGroup { get; set; }

        [Column("rhesusD")]
        [StringLength(10)]
        public string? RhesusD { get; set; }

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