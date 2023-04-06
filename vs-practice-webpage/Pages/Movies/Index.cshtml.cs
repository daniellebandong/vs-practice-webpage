using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using vs_practice_webpage.Data;
using vs_practice_webpage.Models;

namespace vs_practice_webpage.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly vs_practice_webpage.Data.vs_practice_webpageContext _context;

        public IndexModel(vs_practice_webpage.Data.vs_practice_webpageContext context)
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
