using Microsoft.AspNetCore.Mvc;
using HealthcareAPI.Models;
using HealthcareAPI.Services;
using HealthcareAPI.DTOs;

namespace HealthcareAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly IAppointmentService _service;

        public AppointmentsController(IAppointmentService service)
        {
            _service = service;
        }

        // GET all appointments
        [HttpGet]
        public IActionResult GetAll()
        {
            var appointments = _service.GetAll();

            var result = appointments.Select(a => new AppointmentResponseDto
            {
                AppointmentId = a.AppointmentId,
                PatientId = a.PatientId,
                DoctorId = a.DoctorId,
                AppointmentDate = a.AppointmentDate,
                Status = a.Status
            });

            return Ok(result);
        }

        // GET appointments by patient
        [HttpGet("patient/{patientId}")]
        public IActionResult GetByPatient(int patientId)
        {
            return Ok(_service.GetByPatientId(patientId));
        }

        // BOOK appointment
        [HttpPost]
        public IActionResult Add(CreateAppointmentDto dto)
        {
            var appointment = new Appointment
            {
                PatientId = dto.PatientId,
                DoctorId = dto.DoctorId,
                AppointmentDate = dto.AppointmentDate,
                Status = "Booked"
            };

            _service.Book(appointment);
            return Ok(appointment);
        }

        // CANCEL appointment
        [HttpDelete("{id}")]
        public IActionResult Cancel(int id)
        {
            _service.Cancel(id);
            return Ok("Cancelled");
        }
    }
}