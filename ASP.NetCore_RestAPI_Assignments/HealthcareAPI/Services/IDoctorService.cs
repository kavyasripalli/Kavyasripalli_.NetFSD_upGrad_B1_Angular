using HealthcareAPI.Models;

namespace HealthcareAPI.Services
{
    public interface IDoctorService
    {
        IEnumerable<Doctor> GetAllDoctors();
        Doctor GetDoctorBySpecialization(string specialization);
        void AddDoctor(Doctor doctor);
    }
}