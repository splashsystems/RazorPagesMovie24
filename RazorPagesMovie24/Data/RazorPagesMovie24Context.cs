using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie24.Models;

namespace RazorPagesMovie24.Data
{
    public class RazorPagesMovie24Context : DbContext
    {
        public RazorPagesMovie24Context (DbContextOptions<RazorPagesMovie24Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie24.Models.Movie> Movie { get; set; }
    }
}
