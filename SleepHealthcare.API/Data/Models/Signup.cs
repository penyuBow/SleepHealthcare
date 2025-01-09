using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SleepHealthcare.API.Data.Models
{
    public class Signup
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("fname")]
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Column("lname")]
        [StringLength(50)]
        public string? LastName { get; set; }

        [Column("nic")]
        [StringLength(10)]
        public string? NIC { get; set; }

        [Column("address")]
        [StringLength(100)]
        public string? Address { get; set; }

        [Column("contact")]
        public int? Contact { get; set; }

        [Column("email")]
        [StringLength(50)]
        public string? Email { get; set; }

        [Column("gender")]
        [StringLength(50)]
        public string? Gender { get; set; }

        [Column("dob")]
        [StringLength(50)]
        public string? DateOfBirth { get; set; }

        [Column("religion")]
        [StringLength(50)]
        public string? Religion { get; set; }

        [Column("nationality")]
        [StringLength(50)]
        public string? Nationality { get; set; }

        [Column("maritalstatus")]
        [StringLength(50)]
        public string? MaritalStatus { get; set; }

        [Column("medicalhistory")]
        [StringLength(50)]
        public string? MedicalHistory { get; set; }

        [Column("username")]
        [StringLength(50)]
        public string? Username { get; set; }

        [Column("password")]
        [StringLength(50)]
        public string? Password { get; set; }
    }
}
