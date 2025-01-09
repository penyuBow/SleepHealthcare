using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace SleepHealthcare.API.Data.Models
{
    public class Appointment
    {
        [Key]
        [Column("appointment_id")]
        [StringLength(15)]
        public string AppointmentId { get; set; } = string.Empty;

        [Column("date")]
        public DateTime? Date { get; set; }

        [Column("info")]
        [StringLength(100)]
        public string? Info { get; set; }

        [Column("patient_id")]
        [StringLength(10)]
        public string? PatientId { get; set; }

        [Column("bill_id")]
        [StringLength(10)]
        public string? BillId { get; set; }

        [Column("slmc_reg_no")]
        [StringLength(20)]
        public string? SlmcRegNo { get; set; }

        [Column("cancelled")]
        public bool? Cancelled { get; set; }

        // Navigation properties for foreign keys
        [ForeignKey("PatientId")]
        public virtual Patient? Patient { get; set; }

        [ForeignKey("SlmcRegNo")]
        public virtual Doctor? Doctor { get; set; }

        [ForeignKey("BillId")]
        public virtual Bill? Bill { get; set; }
    }
}
