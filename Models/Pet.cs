using System.ComponentModel.DataAnnotations;

namespace ViewModels.Models;

public class Pet
{
    [Required]
    public string Name { get; set; }
    
    [Required]
    public string Type { get; set; }

    [Required(ErrorMessage = "is required!!!!!!!!!!")]
    [Range(0, 120)]
    [Display(Name = "Your Pet's Age")]
    public int? Age { get; set; }

    
    [Display(Name = "Your Pet's Favorite Food")]
    public string? FavoriteFood { get; set; }
}