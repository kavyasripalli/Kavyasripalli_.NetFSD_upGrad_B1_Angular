using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HealthcareAPI.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Specialization { get; set; }

        [Range(0, 50)]
        public int Experience { get; set; }

        [Range(0, 10000)]
        public decimal ConsultationFee { get; set; }

        // Navigation Property
        [System.Text.Json.Serialization.JsonIgnore]
        public ICollection<Appointment>? Appointments { get; set; }
    }
}