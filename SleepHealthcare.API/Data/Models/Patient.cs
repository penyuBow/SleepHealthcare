using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SleepHealthcare.API.Data.Models
{
    public class Patient
    {
        [Key]
        [Column("patient_id")]
        [StringLength(10)]
        public string PatientId { get; set; } = string.Empty;

        [Column("person_id")]
        [StringLength(15)]
        public string? PersonId { get; set; }

        [Column("drug_allergies_and_reactions")]
        [StringLength(500)]
        public string? DrugAllergiesAndReactions { get; set; }
    }

}
