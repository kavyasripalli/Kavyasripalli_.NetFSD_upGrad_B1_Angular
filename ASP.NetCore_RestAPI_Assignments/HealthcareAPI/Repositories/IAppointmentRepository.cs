using HealthcareAPI.Models;

namespace HealthcareAPI.Repositories
{
    public interface IAppointmentRepository
    {
        IEnumerable<Appointment> GetAll();
        IEnumerable<Appointment> GetByPatientId(int patientId);
        void Add(Appointment appointment);
        void Cancel(int id);
    }
}