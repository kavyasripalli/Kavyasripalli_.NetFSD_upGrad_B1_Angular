using Microsoft.AspNetCore.Mvc;
using HealthcareAPI.Models;
using HealthcareAPI.Services;

namespace HealthcareAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorService _service;

        public DoctorsController(IDoctorService service)
        {
            _service = service;
        }

        // GET: api/doctors
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAllDoctors());
        }

        // ADD THIS HERE 👇 (Get by Id)
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var doctor = _service.GetAllDoctors()
                .FirstOrDefault(d => d.DoctorId == id);

            if (doctor == null)
                return NotFound();

            return Ok(doctor);
        }

        // GET: api/doctors/specialization/Cardiology
        [HttpGet("specialization/{specialization}")]
        public IActionResult GetBySpecialization(string specialization)
        {
            var doctor = _service.GetDoctorBySpecialization(specialization);
            if (doctor == null)
                return NotFound();

            return Ok(doctor);
        }

        // POST: api/doctors
        [HttpPost]
        public IActionResult Add(Doctor doctor)
        {
            _service.AddDoctor(doctor);
            return Ok(doctor);
        }
    }
}