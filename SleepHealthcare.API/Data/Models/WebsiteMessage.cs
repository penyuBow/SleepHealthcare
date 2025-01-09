using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SleepHealthcare.API.Data.Models
{
    public class WebsiteMessage
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("first_name")]
        [StringLength(60)]
        public string? FirstName { get; set; }

        [Column("last_name")]
        [StringLength(70)]
        public string? LastName { get; set; }

        [Column("email")]
        [StringLength(100)]
        public string? Email { get; set; }

        [Column("message")]
        [StringLength(1000)]
        public string? MessageContent { get; set; }
    }
}
