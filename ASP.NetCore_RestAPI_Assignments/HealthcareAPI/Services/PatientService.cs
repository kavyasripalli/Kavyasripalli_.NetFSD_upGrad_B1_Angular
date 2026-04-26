using HealthcareAPI.Models;
using HealthcareAPI.Repositories;

namespace HealthcareAPI.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _repository;

        public PatientService(IPatientRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Patient> GetAllPatients()
        {
            return _repository.GetAll();
        }

        public Patient GetPatientById(int id)
        {
            return _repository.GetById(id);
        }

        public void CreatePatient(Patient patient)
        {
            _repository.Add(patient);
        }

        public void UpdatePatient(Patient patient)
        {
            _repository.Update(patient);
        }

        public void DeletePatient(int id)
        {
            _repository.Delete(id);
        }
    }
}