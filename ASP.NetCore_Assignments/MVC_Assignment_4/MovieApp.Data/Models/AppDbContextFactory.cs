using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MovieApp.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            optionsBuilder.UseSqlServer(
                "Data Source=DESKTOP-DA9RDQ5\\SQLEXPRESS;Initial Catalog=MovieDB;Integrated Security=True;TrustServerCertificate=True;"
            );

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}