using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SleepHealthcare.API.Data.Models
{
    public class Person
    {
        [Key]
        [Column("person_id")]
        [StringLength(15)]
        public string PersonId { get; set; } = string.Empty;

        [Column("user_id")]
        [StringLength(10)]
        public string? UserId { get; set; }

        [Column("nic")]
        [StringLength(10)]
        public string? Nic { get; set; }

        [Column("gender")]
        [StringLength(1)]
        public string? Gender { get; set; }

        [Column("date_of_birth")]
        public DateTime? DateOfBirth { get; set; }

        [Column("address")]
        [StringLength(50)]
        public string? Address { get; set; }

        [Column("mobile")]
        [StringLength(10)]
        public string? Mobile { get; set; }

        [Column("first_name")]
        [StringLength(20)]
        public string? FirstName { get; set; }

        [Column("last_name")]
        [StringLength(20)]
        public string? LastName { get; set; }

        [Column("email")]
        [StringLength(50)]
        public string? Email { get; set; }

        [Column("nationality")]
        [StringLength(20)]
        public string? Nationality { get; set; }

        [Column("religion")]
        [StringLength(20)]
        public string? Religion { get; set; }
    }
}
