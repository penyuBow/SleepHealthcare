using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SleepHealthcare.API.Data.Models
{
    public class SysUser
    {
        [Key]
        [Column("user_id")]
        [StringLength(10)]
        public string UserId { get; set; } = string.Empty;

        [Column("person_id")]
        [StringLength(15)]
        public string? PersonId { get; set; }

        [Column("user_name")]
        [StringLength(20)]
        public string? UserName { get; set; }

        [Column("user_type")]
        [StringLength(15)]
        public string? UserType { get; set; }

        [Column("other_info")]
        [StringLength(100)]
        public string? OtherInfo { get; set; }

        [Column("password")]
        [StringLength(35)]
        public string? Password { get; set; }

        [Column("online")]
        public bool? Online { get; set; }

        [Column("login")]
        public DateTime? Login { get; set; }

        [Column("logout")]
        public DateTime? Logout { get; set; }

        [Column("profile_pic")]
        [StringLength(20)]
        public string? ProfilePic { get; set; } = "p2.png";

        [Column("suspend")]
        public int? Suspend { get; set; }

        // Navigation property for foreign key relationship
        public virtual Person? Person { get; set; }
    }
}
