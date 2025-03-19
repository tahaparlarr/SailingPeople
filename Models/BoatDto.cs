using SailingPeople.Domain;
using SailingPeople.Migrations;
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
        Image = boat.Image;
        BoatImages = boat.BoatImages.Select(p => new BoatImageDto(p)).ToList();
        Width = boat.Width;
        Length = boat.Length;
        Cabin = boat.Cabin;
        Guest = boat.Guest;
        CategoryId = boat.CategoryId;
        Category = boat.Category != null ? new CategoryDto(boat.Category) : null; Code = boat.Code;
        MayToOctoberPrice = boat.MayToOctoberPrice;
        JunePrice = boat.JunePrice;
        JulyToAugustPrice = boat.JulyToAugustPrice;
        SeptemberPrice = boat.SeptemberPrice;
    }

    public Guid Id { get; set; } = Guid.NewGuid();

    [Display(Name = "Name")]
    [Required()]
    public string? Name { get; set; }
    public string? ShortName { get; set; }


    [Display(Name = "Category")]
    [Required(ErrorMessage = "Lütfen bir kategori seçiniz")]
    public Guid CategoryId { get; set; }
    public CategoryDto? Category { get; set; }

    [Display(Name = "Code")]
    [Required()]
    public string Code { get; set; }

    [Display(Name = "May-October Price")]
    [Required()]
    public decimal MayToOctoberPrice { get; set; }

    [Display(Name = "June Price")]
    [Required()]
    public decimal JunePrice { get; set; }

    [Display(Name = "July-August Price")]
    [Required()]
    public decimal JulyToAugustPrice { get; set; }

    [Display(Name = "September Price")]
    [Required()]
    public decimal SeptemberPrice { get; set; }
    public string? Image { get; set; }

    [Display(Name = "Cover Image")]
    [Required(ErrorMessage = "Lütfen bir resim seçiniz.")]
    public IFormFile ImageFile { get; set; }

    [Display(Name = "Images")]
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

    public virtual ICollection<BoatImageDto> BoatImages { get; set; } = new List<BoatImageDto>();

}
