using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesSong.Data;
using RazorPagesSong.Models;

namespace RazorPagesSong.Pages_Songs
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesSong.Data.RazorPagesSongContext _context;

        public DetailsModel(RazorPagesSong.Data.RazorPagesSongContext context)
        {
            _context = context;
        }

      public Song Song { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Song == null)
            {
                return NotFound();
            }

            var song = await _context.Song.FirstOrDefaultAsync(m => m.Id == id);
            if (song == null)
            {
                return NotFound();
            }
            else 
            {
                Song = song;
            }
            return Page();
        }
    }
}
