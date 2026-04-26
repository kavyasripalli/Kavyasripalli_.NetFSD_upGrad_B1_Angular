using HealthcareAPI.Models;
using HealthcareAPI.Repositories;

namespace HealthcareAPI.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _repository;

        public AppointmentService(IAppointmentRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Appointment> GetAll()
        {
            return _repository.GetAll();
        }

        public IEnumerable<Appointment> GetByPatientId(int patientId)
        {
            return _repository.GetByPatientId(patientId);
        }

        public void Book(Appointment appointment)
        {
            _repository.Add(appointment);
        }

        public void Cancel(int id)
        {
            _repository.Cancel(id);
        }
    }
}