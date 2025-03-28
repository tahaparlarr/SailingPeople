using System.ComponentModel.DataAnnotations;

namespace SailingPeople.Models;

public class CodeFilterViewModel
{
    [Display(Name = "Code")]
    public string BoatCode { get; set; }

}
