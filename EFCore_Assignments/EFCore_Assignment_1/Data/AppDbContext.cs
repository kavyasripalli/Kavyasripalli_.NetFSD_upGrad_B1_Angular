using Microsoft.EntityFrameworkCore;
using EFCore_Assignment_1.Models;

namespace EFCore_Assignment_1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
    }
}