using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppLocation.Model;

namespace WebAppLocation.Data
{
    public class WebAppLocationContext : DbContext
    {
        public WebAppLocationContext (DbContextOptions<WebAppLocationContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppLocation.Model.Movie> Movie { get; set; }
    }
}
