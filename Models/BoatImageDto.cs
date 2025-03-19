using SailingPeople.Domain;

namespace SailingPeople.Models;

public class BoatImageDto
{
    public BoatImageDto()
    {
           
    }

    public BoatImageDto(BoatImage boatImage)
    {
        Id = boatImage.Id;
        BoatId= boatImage.BoatId;
        Image = boatImage.Image;
    }
    public Guid Id { get; set; }
    public Guid BoatId { get; set; }
    public string Image { get; set; } = null!;
}
