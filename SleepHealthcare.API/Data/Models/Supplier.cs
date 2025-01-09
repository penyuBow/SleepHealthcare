using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SleepHealthcare.API.Data.Models
{
    public class Supplier
    {
        [Key]
        [Column("supplier_id")]
        [StringLength(10)]
        public string? SupplierId { get; set; }

        [Column("supplier_name")]
        [StringLength(50)]
        public string? SupplierName { get; set; }
    }
}
