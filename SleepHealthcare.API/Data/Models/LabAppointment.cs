using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SleepHealthcare.API.Data.Models
{
    public class LabAppointment
    {
        [Key]
        [Column("lab_appointment_id")]
        [StringLength(15)]
        public string LabAppointmentId { get; set; } = string.Empty;

        [Column("test_id")]
        [StringLength(10)]
        public string? TestId { get; set; }

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

        [Column("lab_assistant_id")]
        [StringLength(20)]
        public string? LabAssistantId { get; set; }

        [Column("cancelled")]
        public bool? Cancelled { get; set; }

        [Column("doctor_id")]
        [StringLength(15)]
        public string? DoctorId { get; set; }
    }
}
