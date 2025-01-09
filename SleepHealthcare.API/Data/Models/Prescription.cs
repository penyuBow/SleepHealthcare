using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SleepHealthcare.API.Data.Models
{
    public class Prescription
    {
        [Key]
        [Column("prescription_id")]
        [StringLength(10)]
        public string PrescriptionId { get; set; } = string.Empty;

        [Column("patient_id")]
        [StringLength(10)]
        public string? PatientId { get; set; }

        [Column("consultant_id")]
        [StringLength(20)]
        public string? ConsultantId { get; set; }

        [Column("date")]
        public DateTime? Date { get; set; }

        [Column("drugs_dose")]
        [StringLength(300)]
        public string? DrugsDose { get; set; }

        [Column("tests")]
        [StringLength(100)]
        public string? Tests { get; set; }
    }
}
