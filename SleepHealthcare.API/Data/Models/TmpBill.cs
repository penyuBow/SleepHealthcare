using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SleepHealthcare.API.Data.Models
{
    public class TmpBill
    {
        [Key]
        [Column("tmp_bill_id")]
        [StringLength(10)]
        public string TmpBillId { get; set; } = null!;

        [Column("doctor_fee")]
        public int? DoctorFee { get; set; }

        [Column("hospital_fee")]
        public int? HospitalFee { get; set; }

        [Column("pharmacy_fee")]
        public int? PharmacyFee { get; set; }

        [Column("laboratory_fee")]
        public int? LaboratoryFee { get; set; }

        [Column("appointment_fee")]
        public int? AppointmentFee { get; set; }

        [Column("vat")]
        public int? Vat { get; set; }

        [Column("discount")]
        public int? Discount { get; set; }

        [Column("consultant_id")]
        [StringLength(10)]
        public string? ConsultantId { get; set; }

        [Column("patient_id")]
        [StringLength(10)]
        public string? PatientId { get; set; }
    }
}
