using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SleepHealthcare.API.Data.Models
{
    public class MedicalHistory
    {
        [Key]
        [Column("history_id")]
        [StringLength(15)]
        public string HistoryId { get; set; } = string.Empty;

        [Column("patient_id")]
        [StringLength(10)]
        public string? PatientId { get; set; }

        [Column("doctor_id")]
        [StringLength(20)]
        public string? DoctorId { get; set; }

        [Column("date")]
        public DateTime? Date { get; set; }

        [Column("history")]
        [StringLength(500)]
        public string? History { get; set; }
    }
}
