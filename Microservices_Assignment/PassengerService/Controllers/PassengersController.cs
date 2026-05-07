using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PassengerService.Data;
using PassengerService.Models;

namespace PassengerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengersController : ControllerBase
    {
        private readonly PassengerDbContext _context;

        public PassengersController(PassengerDbContext context)
        {
            _context = context;
        }

        // GET: api/passengers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Passenger>>> GetPassengers()
        {
            return await _context.Passengers.ToListAsync();
        }

        // POST: api/passengers
        [HttpPost]
        public async Task<ActionResult<Passenger>> AddPassenger(Passenger passenger)
        {
            _context.Passengers.Add(passenger);

            await _context.SaveChangesAsync();

            return Ok(passenger);
        }
    }
}