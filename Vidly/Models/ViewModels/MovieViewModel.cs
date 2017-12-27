using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models.ViewModels
{
    public class MovieViewModel
    {
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Genre")]
        public int? GenreId { get; set; }
        [Display(Name = "Release Date"), Required]
        public DateTime? ReleaseDate { get; set; }
        [Display(Name = "Number in Stock")]
        [Range(1, 10)]
        [Required]
        public byte? NumberInStock { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public MovieViewModel()
        {
            Id = 0;
        }
        public MovieViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }
}