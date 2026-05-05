using System.ComponentModel.DataAnnotations;

namespace HealthcareAPI.DTOs
{
    public class CreateDoctorDto
    {
        [Required]
        public string Name { get; set; }

        public string Specialization { get; set; }

        public int Experience { get; set; }

        public decimal ConsultationFee { get; set; }
    }
}