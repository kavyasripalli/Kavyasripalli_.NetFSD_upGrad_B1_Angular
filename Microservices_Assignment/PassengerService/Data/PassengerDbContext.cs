using Microsoft.EntityFrameworkCore;
using PassengerService.Models;

namespace PassengerService.Data
{
    public class PassengerDbContext : DbContext
    {
        public PassengerDbContext(DbContextOptions<PassengerDbContext> options)
            : base(options)
        {

        }

        public DbSet<Passenger> Passengers { get; set; }
    }
}