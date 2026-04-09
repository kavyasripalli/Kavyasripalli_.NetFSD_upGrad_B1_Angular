using Microsoft.EntityFrameworkCore;
using MovieApp.Business.Services;
using MovieApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllersWithViews();

// DB Context
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Business Layer
builder.Services.AddScoped<IMovieService, MovieService>();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Movie}/{action=Index}/{id?}");

app.Run();