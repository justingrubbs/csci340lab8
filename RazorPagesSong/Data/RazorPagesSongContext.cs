using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesSong.Models;

namespace RazorPagesSong.Data
{
    public class RazorPagesSongContext : DbContext
    {
        public RazorPagesSongContext (DbContextOptions<RazorPagesSongContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesSong.Models.Song> Song { get; set; } = default!;
    }
}
