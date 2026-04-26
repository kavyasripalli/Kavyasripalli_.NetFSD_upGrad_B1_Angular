using HealthcareAPI.Models;
using HealthcareAPI.Repositories;

namespace HealthcareAPI.Services
{
    public class PrescriptionService : IPrescriptionService
    {
        private readonly IPrescriptionRepository _repository;

        public PrescriptionService(IPrescriptionRepository repository)
        {
            _repository = repository;
        }

        public void AddPrescription(Prescription prescription)
        {
            _repository.Add(prescription);
        }

        public Prescription GetByAppointmentId(int appointmentId)
        {
            return _repository.GetByAppointmentId(appointmentId);
        }
    }
}