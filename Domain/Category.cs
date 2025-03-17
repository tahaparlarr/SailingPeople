using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace SailingPeople.Domain;

public class Category
{
    public Guid Id { get; set; }

    public required string NameTr { get; set; }

    public required string NameEn { get; set; }
    public virtual ICollection<Boat> Boats { get; set; } = [];
}

public class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasData(
            new Category { Id = Guid.Parse("{4CDF4CD0-DDA7-41ED-BF55-76A2C5DBF0A0}"), NameTr = "Katamaran", NameEn = "Catamaran" },
            new Category { Id = Guid.Parse("{9AB03277-4A7F-401E-9677-02D6853227F0}"), NameTr = "Motor Yat", NameEn = "Motor Yacht" },
            new Category { Id = Guid.Parse("{9A242089-51BC-4F73-B2D5-033C4E20003F}"), NameTr = "Gulet", NameEn = "Gulet" },
            new Category { Id = Guid.Parse("{A2092EE2-5218-4846-A716-024B57C1989E}"), NameTr = "Yelkenli", NameEn = "Sailing Yacht" }
            );
    }
}