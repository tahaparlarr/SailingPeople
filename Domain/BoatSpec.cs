using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SailingPeople.Domain;

public class BoatSpec
{
    public Guid BoatId { get; set; }
    public Guid SpecId { get; set; }
    public string? ValueTr { get; set; }
    public string? ValueEn { get; set; } 
    public virtual Boat? Boat { get; set; }
    public virtual Spec? Spec { get; set; }
    public string LocalizedValue
    {
        get
        {
            var culture = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;

            if (culture == "tr")
            {
                return ValueTr;
            }
            return ValueEn;
        }

    }
}

public class BoatSpecEntityTypeConfiguration : IEntityTypeConfiguration<BoatSpec>
{
    public void Configure(EntityTypeBuilder<BoatSpec> builder)
    {
    }
}