namespace SailingPeople.Domain
{
    public class BoatImage
    {
        public Guid Id { get; set; }
        public Guid BoatId { get; set; }
        public string Image { get; set; } = null!;
        public virtual Boat? Boat { get; set; }
    }
}
