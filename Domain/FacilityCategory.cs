using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace SailingPeople.Domain;

public class FacilityCategory
{
    public Guid Id { get; set; }
    public required string NameTr { get; set; }
    public required string NameEn { get; set; }
    public virtual ICollection<Facility> Facilities { get; set; } = new List<Facility>();
}

public class FacilityCategoryEntityTypeConfiguration : IEntityTypeConfiguration<FacilityCategory>
{
    public void Configure(EntityTypeBuilder<FacilityCategory> builder)
    {
        builder.HasData(
new FacilityCategory { Id = Guid.Parse("{A1E93A3D-6F42-4A15-A0C8-ABF80693F9BC}"), NameTr = "Sanitasyon Tesisleri", NameEn = "Sanitary Facilities" },
    new FacilityCategory { Id = Guid.Parse("{1DB7A378-5E4E-4C61-B0A2-F7DAB56F6D51}"), NameTr = "Mutfak Ekipmanları", NameEn = "Kitchen Equipment" },
    new FacilityCategory { Id = Guid.Parse("{A3F47C0E-30A6-4C89-A4A0-5AC20551D595}"), NameTr = "Dış Ekipmanlar", NameEn = "Exterior Equipment" },
    new FacilityCategory { Id = Guid.Parse("{E00C8365-914D-4874-99B5-6C43D6A96717}"), NameTr = "Güvenlik", NameEn = "Security" },
    new FacilityCategory { Id = Guid.Parse("{B2F7E13B-001A-48BB-B4EF-B387C5D90A4C}"), NameTr = "Yacht Konforu", NameEn = "Comfort on Board" },
    new FacilityCategory { Id = Guid.Parse("{C1C48A44-6B02-4E6A-95C5-1D262788B7F0}"), NameTr = "Ekstra Ekipmanlar", NameEn = "Additional Equipment" }

        );
    }
}