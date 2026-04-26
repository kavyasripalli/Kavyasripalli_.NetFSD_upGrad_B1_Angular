using Microsoft.AspNetCore.Mvc;
using FlightAPI.Models;
using FlightAPI.Repository;

namespace FlightAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FlightController : ControllerBase
    {
        private readonly IFlightRepository _repo;

        public FlightController(IFlightRepository repo)
        {
            _repo = repo;
        }

        // GetAll()
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repo.GetAllFlights());
        }

        // Get(id)
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var flight = _repo.GetFlight(id);
            if (flight == null)
                return NotFound();

            return Ok(flight);
        }

        // Add()
        [HttpPost]
        public IActionResult Add(Flight flight)
        {
            _repo.AddFlight(flight);
            return Ok("Flight Added");
        }

        // Update()
        [HttpPut]
        public IActionResult Update(Flight flight)
        {
            _repo.EditFlight(flight);
            return Ok("Flight Updated");
        }

        // Delete(id)
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repo.DeleteFlight(id);
            return Ok("Flight Deleted");
        }
    }
}