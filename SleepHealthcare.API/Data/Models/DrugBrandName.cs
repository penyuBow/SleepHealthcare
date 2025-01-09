using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SleepHealthcare.API.Data.Models
{
    public class DrugBrandName
    {

        [Key]
        [Column("brand_id")]
        [StringLength(10)]
        public string BrandId { get; set; } = string.Empty;

        [Column("brand_name")]
        [StringLength(40)]
        public string? BrandName { get; set; }

        [Column("generic_name")]
        [StringLength(40)]
        public string? GenericName { get; set; }

        [Column("drug_type")]
        [StringLength(20)]
        public string? DrugType { get; set; }

        [Column("drug_unit")]
        [StringLength(10)]
        public string? DrugUnit { get; set; }

        [Column("unit_price")]
        public int? UnitPrice { get; set; }
    }
}
