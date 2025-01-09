using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SleepHealthcare.API.Data.Models
{
    public class LabTest
    {
        [Key]
        [Column("test_id")]
        [StringLength(10)]
        public string TestId { get; set; } = string.Empty;

        [Column("test_name")]
        [StringLength(50)]
        public string? TestName { get; set; }

        [Column("test_description")]
        [StringLength(150)]
        public string? TestDescription { get; set; }

        [Column("test_fee")]
        public int? TestFee { get; set; }
    }
}
