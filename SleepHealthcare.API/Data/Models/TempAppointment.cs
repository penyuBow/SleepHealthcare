using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SleepHealthcare.API.Data.Models
{
    public class TempAppointment
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("doctor_id")]
        [StringLength(15)]
        public string? DoctorId { get; set; }

        [Column("time")]
        public TimeSpan? Time { get; set; }

        [Column("date")]
        public DateTime? Date { get; set; }

        [Column("patient_id")]
        [StringLength(15)]
        public string? PatientId { get; set; }  
    }
}
