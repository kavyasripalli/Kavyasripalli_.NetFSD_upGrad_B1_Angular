using Microsoft.AspNetCore.Mvc;
using HealthcareAPI.Models;
using HealthcareAPI.Services;

namespace HealthcareAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrescriptionsController : ControllerBase
    {
        private readonly IPrescriptionService _service;

        public PrescriptionsController(IPrescriptionService service)
        {
            _service = service;
        }

        // POST: api/prescriptions
        [HttpPost]
        public IActionResult Add(Prescription prescription)
        {
            _service.AddPrescription(prescription);
            return Ok(prescription);
        }

        // GET: api/prescriptions/appointment/1
        [HttpGet("appointment/{appointmentId}")]
        public IActionResult GetByAppointment(int appointmentId)
        {
            var result = _service.GetByAppointmentId(appointmentId);

            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}