using HealthcareAPI.Data;
using HealthcareAPI.Models;

namespace HealthcareAPI.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly ApplicationDbContext _context;

        public DoctorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Doctor> GetAll()
        {
            return _context.Doctors.ToList();
        }

        public Doctor GetBySpecialization(string specialization)
        {
            return _context.Doctors
                .FirstOrDefault(d => d.Specialization == specialization);
        }

        public void Add(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
        }
    }
}