using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SleepHealthcare.API.Data.Models
{
    public class PatientMessageReceive
    {
        [Key]
        [Column("message_id")]
        [StringLength(15)]
        public string MessageId { get; set; } = string.Empty;

        [Column("receiver")]
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
        public string? Message { get; set; }

        [Column("date")]
        public DateTime? Date { get; set; }
    }

}
