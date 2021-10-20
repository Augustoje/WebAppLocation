using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppLocation.Data;
using WebAppLocation.Model;

namespace WebAppLocation.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly WebAppLocation.Data.WebAppLocationContext _context;

        public IndexModel(WebAppLocation.Data.WebAppLocationContext context)
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
