using HealthcareAPI.Models;

namespace HealthcareAPI.Repositories
{
    public interface IDoctorRepository
    {
        IEnumerable<Doctor> GetAll();
        Doctor GetBySpecialization(string specialization);
        void Add(Doctor doctor);
    }
}