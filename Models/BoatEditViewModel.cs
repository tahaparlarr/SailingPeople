using Microsoft.AspNetCore.Http; // IFormFile
using System.ComponentModel.DataAnnotations;

namespace SailingPeople.Models
{
    public class BoatEditViewModel
    {
        public Guid Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public Guid CategoryId { get; set; }
        public string Code { get; set; } = null!;
        public decimal MayToOctoberPrice { get; set; }
        public decimal JunePrice { get; set; }
        public decimal JulyToAugustPrice { get; set; }
        public decimal SeptemberPrice { get; set; }
        public float Width { get; set; }
        public float Length { get; set; }
        public int Guest { get; set; }
        public int Cabin { get; set; }

        public string? CoverImage { get; set; }

        public List<BoatImageViewModel> ExistingImages { get; set; } = new();
        public List<IFormFile>? AdditionalImages { get; set; }
        public IFormFile? ImageFile { get; set; }

        public List<Guid> SelectedFacilities { get; set; } = new();
        public List<BoatSpecInputModel> Specs { get; set; } = new();
    }

    public class BoatSpecInputModel
    {
        public Guid SpecId { get; set; }
        public string? ValueTr { get; set; }
    }

    public class BoatImageViewModel
    {
        public Guid Id { get; set; }
        public string Base64Data { get; set; } = null!;
        public bool Remove { get; set; }  // <--- Bu property silinecek resimler için checkbox
    }
}
