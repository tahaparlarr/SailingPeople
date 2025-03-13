using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

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
    public string Code { get; set; } = null!;
    public decimal MayToOctoberPrice { get; set; }
    public decimal JunePrice { get; set; }
    public decimal JulyToAugustPrice { get; set; }
    public decimal SeptemberPrice { get; set; }
    public float Width { get; set; }
    public float Length { get; set; }
    public int Guest { get; set; }
    public int Cabin { get; set; }
    public virtual ICollection<BoatImage> BoatImages{ get; set; } = new List<BoatImage>();
    public virtual ICollection<BoatSpec> BoatSpecs{ get; set; } = new List<BoatSpec>();
    public virtual ICollection<Spec> Specs { get; set; } = new List<Spec>();
    public virtual Category? Category { get; set; }
}

public class BoatEntityTypeConfiguration : IEntityTypeConfiguration<Boat>
{
    public void Configure(EntityTypeBuilder<Boat> builder)
    {
        builder.Property(p => p.Image).IsUnicode(false);
        builder.HasIndex(p => p.CategoryId).IsUnique(false);
        builder.HasIndex(p => p.Cabin).IsUnique(false);
        builder.HasIndex(p => p.Guest).IsUnique(false);


        builder
            .HasMany(p => p.Specs)
            .WithMany(p => p.Boats)
            .UsingEntity<BoatSpec>();

    }
}