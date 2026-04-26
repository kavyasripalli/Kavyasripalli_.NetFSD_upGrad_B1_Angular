using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthcareAPI.Models
{
    public class Prescription
    {
        [Key]
        public int PrescriptionId { get; set; }

        [ForeignKey("Appointment")]
        public int AppointmentId { get; set; }

        public string Diagnosis { get; set; }

        public string Medicines { get; set; }

        public string Notes { get; set; }

        // Navigation Property
        [System.Text.Json.Serialization.JsonIgnore]
        public Appointment? Appointment { get; set; }
    }
}