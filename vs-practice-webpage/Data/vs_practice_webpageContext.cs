using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using vs_practice_webpage.Models;

namespace vs_practice_webpage.Data
{
    public class vs_practice_webpageContext : DbContext
    {
        public vs_practice_webpageContext (DbContextOptions<vs_practice_webpageContext> options)
            : base(options)
        {
        }

        public DbSet<vs_practice_webpage.Models.Movie> Movie { get; set; } = default!;
    }
}
