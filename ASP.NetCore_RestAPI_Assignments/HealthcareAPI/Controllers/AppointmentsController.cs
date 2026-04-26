using Microsoft.AspNetCore.Mvc;
using HealthcareAPI.Models;
using HealthcareAPI.Services;

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
            return Ok(_service.GetAll());
        }

        // GET appointments by patient
        [HttpGet("patient/{patientId}")]
        public IActionResult GetByPatient(int patientId)
        {
            return Ok(_service.GetByPatientId(patientId));
        }

        // BOOK appointment
        [HttpPost]
        public IActionResult Book(Appointment appointment)
        {
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