using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SleepHealthcare.API.Data.Models
{
    public class PatientUserAccount
    {
        [Key]
        [Column("patient_id")]
        [StringLength(10)]
        public string PatientId { get; set; } = string.Empty;

        [Column("person_id")]
        [StringLength(15)]
        public string? PersonId { get; set; }

        [Column("username")]
        [StringLength(15)]
        public string? Username { get; set; }

        [Column("password")]
        [StringLength(50)]
        public string? Password { get; set; }
    }
}
