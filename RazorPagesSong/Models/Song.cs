using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesSong.Models;

public class Song
{
   public int Id { get; set; }

   [StringLength(60, MinimumLength = 1)]
   [Required]
   public string? Title { get; set; }

   [StringLength(60, MinimumLength = 1)]
   [Required]
   public string? Album {get; set;}

   [StringLength(60, MinimumLength = 1)]
   [Required]
   public string? Artist {get; set;}

   [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
   [Required]
   [StringLength(30)]
   public string? Genre { get; set; }

   [Required]
   public bool Explicit {get; set;}

   [Display(Name = "Release Date")]
   [DataType(DataType.Date)]
   public DateTime ReleaseDate { get; set; }
}