namespace SailingPeople.Domain;

public enum RentTypes
{
    Weekly
}
public class Boat
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Image { get; set; }
    public Guid CategoryId { get; set; }
    public RentTypes RentType { get; set; } = RentTypes.Weekly;
    public float Width { get; set; }
    public float Length { get; set; }
    public int Guest { get; set; }
    public int Cabin { get; set; }
    public virtual ICollection<BoatImage> BoatImages{ get; set; } = new List<BoatImage>();
    public virtual Category? Category { get; set; }
}
