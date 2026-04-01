using Microsoft.EntityFrameworkCore;

namespace MVC_Assignment_2.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-RRH9QFR3\\SQLEXPRESS01;Initial Catalog=StudentDetailsDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
    }
}