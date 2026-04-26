using HealthcareAPI.DTOs;
using HealthcareAPI.Models;
using HealthcareAPI.Services;
using Microsoft.AspNetCore.Mvc;
using HealthcareAPI.DTOs;

namespace HealthcareAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientService _service;

        public PatientsController(IPatientService service)
        {
            _service = service;
        }

        // GET: api/patients
        [HttpGet]
        public IActionResult GetAll()
        {
            var patients = _service.GetAllPatients();
            return Ok(patients);
        }

        // GET: api/patients/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var patient = _service.GetPatientById(id);
            if (patient == null)
                return NotFound();

            return Ok(patient);
        }

        // POST: api/patients
        [HttpPost]
        public IActionResult Create(CreatePatientDto dto)
        {
            var patient = new Patient
            {
                Name = dto.Name,
                Age = dto.Age,
                Gender = dto.Gender,
                ContactNumber = dto.ContactNumber,
                Address = dto.Address
            };

            _service.CreatePatient(patient);
            return Ok(patient);
        }

        // PUT: api/patients/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, Patient patient)
        {
            if (id != patient.PatientId)
                return BadRequest();

            _service.UpdatePatient(patient);
            return Ok(patient);
        }

        // DELETE: api/patients/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.DeletePatient(id);
            return Ok();
        }
    }
}