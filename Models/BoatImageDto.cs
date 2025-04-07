using SailingPeople.Domain;

namespace SailingPeople.Models;

public class BoatImageDto
{
    public Guid Id { get; set; }
    public Guid BoatId { get; set; }
    public string Image { get; set; } = null!;
    public int SortOrder { get; set; }
}
