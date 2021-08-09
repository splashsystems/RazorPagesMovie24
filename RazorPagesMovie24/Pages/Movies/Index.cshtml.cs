using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie24.Data;
using RazorPagesMovie24.Models;

namespace RazorPagesMovie24.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie24.Data.RazorPagesMovie24Context _context;

        public IndexModel(RazorPagesMovie24.Data.RazorPagesMovie24Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
