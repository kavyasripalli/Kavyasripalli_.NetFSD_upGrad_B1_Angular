using HealthcareAPI.Models;

namespace HealthcareAPI.Services
{
    public interface IAppointmentService
    {
        IEnumerable<Appointment> GetAll();
        IEnumerable<Appointment> GetByPatientId(int patientId);
        void Book(Appointment appointment);
        void Cancel(int id);
    }
}