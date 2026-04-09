using MovieApp.Data.Models;
using System.Collections.Generic;

namespace MovieApp.Business.Services
{
    public interface IMovieService
    {
        Task<List<Movie>> GetAllMoviesAsync(string genre, string sortOrder);
        Task<Movie> GetMovieByIdAsync(int id);
        Task AddMovieAsync(Movie movie);
        Task UpdateMovieAsync(Movie movie);
        Task DeleteMovieAsync(int id);
    }
}