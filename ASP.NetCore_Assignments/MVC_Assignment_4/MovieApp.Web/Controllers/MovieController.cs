using Microsoft.AspNetCore.Mvc;
using MovieApp.Business.Services;
using MovieApp.Data.Models;

namespace MovieApp.Web.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _service;

        public MovieController(IMovieService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index(string genre, string sortOrder)
        {
            var movies = await _service.GetAllMoviesAsync(genre, sortOrder);
            return View(movies);
        }

        public async Task<IActionResult> Details(int id)
        {
            var movie = await _service.GetMovieByIdAsync(id);
            return View(movie);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                await _service.AddMovieAsync(movie);
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var movie = await _service.GetMovieByIdAsync(id);
            return View(movie);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                await _service.UpdateMovieAsync(movie);
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var movie = await _service.GetMovieByIdAsync(id);
            return View(movie);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _service.DeleteMovieAsync(id);
            return RedirectToAction("Index");
        }
    }
}