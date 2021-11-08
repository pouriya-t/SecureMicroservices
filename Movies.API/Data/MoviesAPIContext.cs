using Microsoft.EntityFrameworkCore;
using Movies.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.API.Data
{
    public class MoviesAPIContext : DbContext
    {
        public MoviesAPIContext(DbContextOptions<MoviesAPIContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
