using Microsoft.AspNetCore.Mvc;
using HealthcareAPI.Models;
using HealthcareAPI.Services;
using HealthcareAPI.DTOs;

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
            var doctors = _service.GetAllDoctors();

            var result = doctors.Select(d => new DoctorResponseDto
            {
                DoctorId = d.DoctorId,
                Name = d.Name,
                Specialization = d.Specialization,
                Experience = d.Experience,
                ConsultationFee = d.ConsultationFee
            });

            return Ok(result);
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

            var result = new DoctorResponseDto
            {
                DoctorId = doctor.DoctorId,
                Name = doctor.Name,
                Specialization = doctor.Specialization,
                Experience = doctor.Experience,
                ConsultationFee = doctor.ConsultationFee
            };

            return Ok(result);
        }

        // POST: api/doctors
        [HttpPost]
        public IActionResult Add(CreateDoctorDto dto)
        {
            var doctor = new Doctor
            {
                Name = dto.Name,
                Specialization = dto.Specialization,
                Experience = dto.Experience,
                ConsultationFee = dto.ConsultationFee
            };

            _service.AddDoctor(doctor);

            return Ok(doctor);
        }
    }
}