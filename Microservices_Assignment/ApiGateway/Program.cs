using Ocelot.DependencyInjection;
using Ocelot.Middleware;
namespace ApiGateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add Ocelot configuration

            builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);

            // Add Ocelot

            builder.Services.AddOcelot();

            var app = builder.Build();

            // Use Ocelot

            app.UseOcelot();

            app.Run();
        }
    }
}
