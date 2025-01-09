using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SleepHealthcare.API.Data.Models
{
    public class Doctor
    {
        [Key]
        [Column("slmc_reg_no")]
        [StringLength(20)]
        public string SlmcRegNo { get; set; } = string.Empty;

        [Column("user_id")]
        [StringLength(10)]
        public string? UserId { get; set; }

        [Column("education")]
        [StringLength(100)]
        public string? Education { get; set; }

        [Column("training")]
        [StringLength(100)]
        public string? Training { get; set; }

        [Column("experienced_areas")]
        [StringLength(100)]
        public string? ExperiencedAreas { get; set; }

        [Column("experience")]
        [StringLength(100)]
        public string? Experience { get; set; }

        [Column("achievements")]
        [StringLength(100)]
        public string? Achievements { get; set; }

        [Column("channelling_fee")]
        public int? ChannellingFee { get; set; }

        // Navigation property for the foreign key
        [ForeignKey("UserId")]
        public virtual SysUser? SysUser { get; set; }
    }
}
