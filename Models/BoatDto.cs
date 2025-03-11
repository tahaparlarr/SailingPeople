using SailingPeople.Domain;
using System.ComponentModel.DataAnnotations;

namespace SailingPeople.Models;

public class BoatDto
{
    public BoatDto()
    {
    }

    public BoatDto(Boat boat)
    {
        Name = boat.Name;
        Id = boat.Id;
        Width = boat.Width;
        Length = boat.Length;
        Cabin = boat.Cabin;
        Guest = boat.Guest;
        CategoryId = boat.CategoryId;
    }
    public Guid Id { get; set; } = Guid.NewGuid();

    [Display(Name = "Name")]
    [Required()]
    public string? Name { get; set; }

    [Display(Name = "Category")]
    [Required()]
    public Guid CategoryId { get; set; }

    [Display(Name = "Cover Image")]
    [Required()]
    public IFormFile? Image { get; set; }

    [Display(Name = "Images")]
    [Required()]
    public IFormFileCollection? Images { get; set; }
    
    [Display(Name = "Width")]
    [Required()]
    public float? Width { get; set; }

    [Display(Name = "Length")] 
    [Required()]
    public float? Length { get; set; }

    [Display(Name = "Guest")]
    [Required()]
    public int? Guest { get; set; }

    [Display(Name = "Cabin")]
    [Required()]
    public int? Cabin { get; set; }
}
