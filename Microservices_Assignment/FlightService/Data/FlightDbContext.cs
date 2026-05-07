using Microsoft.EntityFrameworkCore;
using FlightService.Models;

namespace FlightService.Data
{
    public class FlightDbContext : DbContext
    {
        public FlightDbContext(DbContextOptions<FlightDbContext> options)
            : base(options)
        {

        }

        public DbSet<Flight> Flights { get; set; }
    }
}