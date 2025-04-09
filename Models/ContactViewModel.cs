using SailingPeople.Resources;
using System.ComponentModel.DataAnnotations;

namespace SailingPeople.Models;

public class ContactViewModel
{
    [Required]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [StringLength(100)]
    public string Subject { get; set; }

    [Required]
    [StringLength(300)]
    public string Message { get; set; }
}
