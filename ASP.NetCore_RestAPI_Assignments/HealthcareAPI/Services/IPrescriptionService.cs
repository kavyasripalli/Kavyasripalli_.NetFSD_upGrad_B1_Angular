using HealthcareAPI.Models;

namespace HealthcareAPI.Services
{
    public interface IPrescriptionService
    {
        void AddPrescription(Prescription prescription);
        Prescription GetByAppointmentId(int appointmentId);
    }
}