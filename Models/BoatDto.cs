using SailingPeople.Domain;
using System.ComponentModel.DataAnnotations;

namespace SailingPeople.Models;

public class BoatDto
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [Display(Name = "Name")]
    [Required()]
    public string? Name { get; set; }

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
    public List<int> SortOrders { get; set; }
    public List<SpecDto> Specs { get; set; } = new List<SpecDto>(); 
    public List<BoatSpecDto> BoatSpecs { get; set; } = new List<BoatSpecDto>();

    public List<Facility> Facilities { get; set; } = new List<Facility>();

    public List<Guid> SpecId { get; set; } = new List<Guid>();
    public List<string> SpecValue { get; set; } = new List<string>();

    public List<Guid> FacilityId { get; set; } = new List<Guid>();
    public List<string> FacilityNames { get; set; } = new List<string>();
    public virtual ICollection<BoatImageDto> BoatImages { get; set; } = new List<BoatImageDto>();
}
