using Movies.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.API.Data
{
    public class MoviesContextSeed
    {
        public static void SeedAsync(MoviesAPIContext moviesContext)
        {
            var movies = new List<Movie>
                {
                    new Movie
                    {
                        Id = 1,
                        Genre = "Comics",
                        Title = "asd",
                        Rating = "9.2",
                        ImageUrl = "images/src",
                        ReleaseDate = DateTime.Now,
                        Owner = "swn"
                    },
                     new Movie
                    {
                        Id = 2,
                        Genre = "Comics 2",
                        Title = "asd 2",
                        Rating = "11.2",
                        ImageUrl = "images/src",
                        ReleaseDate = DateTime.Now,
                        Owner = "swn 2"
                    },
                };
            moviesContext.Movie.AddRange(movies);
            moviesContext.SaveChanges();
        }
    }
}
