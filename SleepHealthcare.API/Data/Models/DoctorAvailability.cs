using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SleepHealthcare.API.Data.Models
{
    public class DoctorAvailability
    {

        [Key]
        [Column("time_slot_id")]
        [StringLength(10)]
        public string TimeSlotId { get; set; } = string.Empty;

        [Column("slmc_reg_no")]
        [StringLength(20)]
        public string? SlmcRegNo { get; set; }

        [Column("day")]
        public int? Day { get; set; }

        [Column("time_slot")]
        [StringLength(15)]
        public string? TimeSlot { get; set; }

        [Column("current_week_appointments")]
        public int? CurrentWeekAppointments { get; set; }

        [Column("next_week_appointments")]
        public int? NextWeekAppointments { get; set; }

        // Navigation property for the foreign key
        [ForeignKey("SlmcRegNo")]
        public virtual Doctor? Doctor { get; set; }
    }
}
