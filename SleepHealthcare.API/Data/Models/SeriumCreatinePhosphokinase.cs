using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SleepHealthcare.API.Data.Models
{
    public class SeriumCreatinePhosphokinase
    {
        [Key]
        [Column("tst_SCP_id")]
        [StringLength(10)]
        public string SCPTestId { get; set; } = string.Empty;

        [Column("prescription_id")]
        [StringLength(10)]
        public string? PrescriptionId { get; set; }

        [Column("hiv12ELISA")]
        [StringLength(10)]
        public string? Hiv12ELISA { get; set; }

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
