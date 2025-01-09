using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SleepHealthcare.API.Data.Models
{
    public class LabAssistant
    {
        [Key]
        [Column("lab_assistant_id")]
        [StringLength(10)]
        public string LabAssistantId { get; set; } = string.Empty;

        [Column("user_id")]
        [StringLength(10)]
        public string? UserId { get; set; }

        [Column("education")]
        [StringLength(100)]
        public string? Education { get; set; }

        [Column("training")]
        [StringLength(100)]
        public string? Training { get; set; }

        [Column("experience")]
        [StringLength(100)]
        public string? Experience { get; set; }

        [Column("achievements")]
        [StringLength(100)]
        public string? Achievements { get; set; }
    }
}
