﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PagesMovies.Data;
using PagesMovies.Models;

namespace PagesMovies.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly PagesMovies.Data.PagesMoviesContext _context;

        public IndexModel(PagesMovies.Data.PagesMoviesContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
