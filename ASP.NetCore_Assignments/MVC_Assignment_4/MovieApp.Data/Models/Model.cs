using System;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.Data.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; } = string.Empty;

        public string Genre { get; set; }

        public DateTime ReleaseDate { get; set; }

        [Range(1, 500, ErrorMessage = "Duration must be positive")]
        public int Duration { get; set; }

        [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10")]
        public double Rating { get; set; }

        public string Language { get; set; }
    }
}