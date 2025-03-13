using System.ComponentModel.DataAnnotations;

namespace SailingPeople.Models;

public class FilterViewModel
{
    [Display(Name = "BoatType")]
    public Guid CategoryId { get; set; }

    [Display(Name = "Cabin")]
    public int Cabin { get; set; }

    [Display(Name = "Guests")]
    public int Guests { get; set; }

}
