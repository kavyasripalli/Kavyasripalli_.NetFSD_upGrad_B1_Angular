using HealthcareAPI.Data;
using HealthcareAPI.Models;

namespace HealthcareAPI.Repositories
{
    public class PrescriptionRepository : IPrescriptionRepository
    {
        private readonly ApplicationDbContext _context;

        public PrescriptionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Prescription prescription)
        {
            _context.Prescriptions.Add(prescription);
            _context.SaveChanges();
        }

        public Prescription GetByAppointmentId(int appointmentId)
        {
            return _context.Prescriptions
                .FirstOrDefault(p => p.AppointmentId == appointmentId);
        }
    }
}