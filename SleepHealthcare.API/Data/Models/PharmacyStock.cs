using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SleepHealthcare.API.Data.Models
{

    public class PharmacyStock
    {
        [Key]
        [Column("stock_id")]
        [StringLength(10)]
        public string StockId { get; set; } = string.Empty;

        [Column("drug_id")]
        [StringLength(15)]
        public string? DrugId { get; set; }

        [Column("brand_id")]
        [StringLength(15)]
        public string? BrandId { get; set; }

        [Column("stock")]
        public int? Stock { get; set; }

        [Column("remaining_quantity")]
        public int? RemainingQuantity { get; set; }

        [Column("manufac_date")]
        public DateTime? ManufacturingDate { get; set; }

        [Column("exp_date")]
        public DateTime? ExpirationDate { get; set; }

        [Column("supplier_id")]
        [StringLength(10)]
        public string? SupplierId { get; set; }

        [Column("date")]
        public DateTime? Date { get; set; }
    }

}
