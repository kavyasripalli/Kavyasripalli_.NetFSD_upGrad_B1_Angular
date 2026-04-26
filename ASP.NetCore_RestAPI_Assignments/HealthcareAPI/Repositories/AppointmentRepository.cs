using HealthcareAPI.Data;
using HealthcareAPI.Models;

namespace HealthcareAPI.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly ApplicationDbContext _context;

        public AppointmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Appointment> GetAll()
        {
            return _context.Appointments.ToList();
        }

        public IEnumerable<Appointment> GetByPatientId(int patientId)
        {
            return _context.Appointments
                .Where(a => a.PatientId == patientId)
                .ToList();
        }

        public void Add(Appointment appointment)
        {
            // Important: set default status
            appointment.Status = "Booked";

            _context.Appointments.Add(appointment);
            _context.SaveChanges();
        }

        public void Cancel(int id)
        {
            var appt = _context.Appointments.Find(id);
            if (appt != null)
            {
                appt.Status = "Cancelled";
                _context.SaveChanges();
            }
        }
    }
}