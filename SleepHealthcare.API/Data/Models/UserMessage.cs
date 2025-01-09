using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SleepHealthcare.API.Data.Models
{
    public class UserMessage
    {
        [Key]
        [Column("message_id")]
        [StringLength(15)]
        public string MessageId { get; set; } = null!;

        [Column("reciver")]
        [StringLength(20)]
        public string? Receiver { get; set; }

        [Column("sender")]
        [StringLength(20)]
        public string? Sender { get; set; }

        [Column("subject")]
        [StringLength(50)]
        public string? Subject { get; set; }

        [Column("message")]
        [StringLength(500)]
        public string? MessageContent { get; set; }

        [Column("date")]
        public DateTime? Date { get; set; }

        [Column("rd")]
        public bool IsRead { get; set; } = false;
    }
}
