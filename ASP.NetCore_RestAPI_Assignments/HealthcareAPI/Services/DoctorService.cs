using HealthcareAPI.Models;
using HealthcareAPI.Repositories;

namespace HealthcareAPI.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _repository;

        public DoctorService(IDoctorRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Doctor> GetAllDoctors()
        {
            return _repository.GetAll();
        }

        public Doctor GetDoctorBySpecialization(string specialization)
        {
            return _repository.GetBySpecialization(specialization);
        }

        public void AddDoctor(Doctor doctor)
        {
            _repository.Add(doctor);
        }
    }
}