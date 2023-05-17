using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PagesMovies.Models;

namespace PagesMovies.Data
{
    public class PagesMoviesContext : DbContext
    {
        public PagesMoviesContext (DbContextOptions<PagesMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<PagesMovies.Models.Movie> Movie { get; set; } = default!;
    }
}
