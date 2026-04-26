using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthcareAPI.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        [ForeignKey("Patient")]
        public int PatientId { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }

        public DateTime AppointmentDate { get; set; }

        public string? Status { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public Patient? Patient { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public Doctor? Doctor { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public Prescription? Prescription { get; set; }
    }
}