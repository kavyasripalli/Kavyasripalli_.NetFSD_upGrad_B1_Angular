using HealthcareAPI.Models;

namespace HealthcareAPI.Repositories
{
    public interface IPrescriptionRepository
    {
        void Add(Prescription prescription);
        Prescription GetByAppointmentId(int appointmentId);
    }
}