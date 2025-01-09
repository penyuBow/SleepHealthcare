using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SleepHealthcare.API.Data.Models
{
    public class LabAppointmentTimetable
    {
        [Key]
        [Column("app_id")]
        [StringLength(15)]
        public string AppId { get; set; } = string.Empty;

        [Column("app_test_id")]
        [StringLength(15)]
        public string? AppTestId { get; set; }

        [Column("app_day")]
        public int? AppDay { get; set; }

        [Column("time_slot")]
        [StringLength(15)]
        public string? TimeSlot { get; set; }

        [Column("current_week_appointments")]
        public int? CurrentWeekAppointments { get; set; }

        [Column("next_week_appointments")]
        public int? NextWeekAppointments { get; set; }
    }
}
