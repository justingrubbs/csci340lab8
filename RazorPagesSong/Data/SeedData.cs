using Microsoft.EntityFrameworkCore;
using RazorPagesSong.Data;

namespace RazorPagesSong.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RazorPagesSongContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesSongContext>>()))
        {
            if (context == null || context.Song == null)
            {
                throw new ArgumentNullException("Null RazorPagesSongContext");
            }

            // Look for any movies.
            if (context.Song.Any())
            {
                return;   // DB has been seeded
            }

            context.Song.AddRange(

               new Song {
                  Title = "Seigfried",
                  Album = "Blonde",
                  Artist = "Frank Ocean",
                  Genre = "R&B",
                  Explicit = false,
                  ReleaseDate = DateTime.Parse("2016-08-20"),
               },

               new Song {
                  Title = "ATTENTION",
                  Album = "BALLADS 1",
                  Artist = "Joji",
                  Genre = "R&B",
                  Explicit = true,
                  ReleaseDate = DateTime.Parse("2018-10-26"),
               },

               new Song {
                  Title = "Loveless",
                  Album = "Lo Moon",
                  Artist = "Lo Moon",
                  Genre = "Indie-pop",
                  Explicit = false,
                  ReleaseDate = DateTime.Parse("2018-02-23"),
               },

               new Song {
                  Title = "Dizzy On the Comedown",
                  Album = "Peripheral Vision",
                  Artist = "Turnover",
                  Genre = "Indie-rock",
                  Explicit = false,
                  ReleaseDate = DateTime.Parse("2015-09-04"),
               },

               new Song {
                  Title = "Let It All Out (10:05)",
                  Album = "Dreamland",
                  Artist = "COIN",
                  Genre = "Alternative",
                  Explicit = false,
                  ReleaseDate = DateTime.Parse("2019-11-15"),
               }
            );
            context.SaveChanges();
        }
    }
}