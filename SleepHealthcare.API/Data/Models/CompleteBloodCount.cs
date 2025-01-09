using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SleepHealthcare.API.Data.Models
{
    public class CompleteBloodCount
    {
        [Key]
        [Column("tst_CBC_id")]
        [StringLength(10)]
        public string TstCbcId { get; set; } = string.Empty;

        [Column("prescription_id")]
        [StringLength(10)]
        public string? PrescriptionId { get; set; }

        [Column("totalWhiteCellCount")]
        public int? TotalWhiteCellCount { get; set; }

        [Column("differentialCount")]
        public int? DifferentialCount { get; set; }

        [Column("neutrophils")]
        public int? Neutrophils { get; set; }

        [Column("lymphocytes")]
        public int? Lymphocytes { get; set; }

        [Column("monocytes")]
        public int? Monocytes { get; set; }

        [Column("eosonophils")]
        public int? Eosonophils { get; set; }

        [Column("basophils")]
        public int? Basophils { get; set; }

        [Column("haemoglobin")]
        public float? Haemoglobin { get; set; }

        [Column("redBloodCells")]
        public float? RedBloodCells { get; set; }

        [Column("meanCellVolume")]
        public float? MeanCellVolume { get; set; }

        [Column("haematocrit")]
        public float? Haematocrit { get; set; }

        [Column("meanCellHaemoglobin")]
        public float? MeanCellHaemoglobin { get; set; }

        [Column("mchConcentration")]
        public float? MchConcentration { get; set; }

        [Column("redCellsDistributionWidth")]
        public float? RedCellsDistributionWidth { get; set; }

        [Column("plateletCount")]
        public int? PlateletCount { get; set; }

        [Column("appointment_id")]
        [StringLength(15)]
        public string? AppointmentId { get; set; }

        [Column("date")]
        public DateTime? Date { get; set; }

        // Navigation properties for foreign keys
        [ForeignKey("PrescriptionId")]
        public virtual Prescription? Prescription { get; set; }
    }
}
