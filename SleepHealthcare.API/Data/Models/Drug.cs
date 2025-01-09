using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SleepHealthcare.API.Data.Models
{
    public class Drug
    {
        [Key]
        [Column("drug_id")]
        [StringLength(10)]
        public string DrugId { get; set; } = string.Empty;

        [Column("drug_name")]
        [StringLength(20)]
        public string? DrugName { get; set; }

        [Column("dangerous_drug")]
        public bool? DangerousDrug { get; set; }
    }
}
