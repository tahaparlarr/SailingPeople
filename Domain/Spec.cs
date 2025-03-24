using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace SailingPeople.Domain;

public class Spec
{
    public Guid Id { get; set; }
    public required string NameTr { get; set; }
    public required string NameEn { get; set; }
    public virtual ICollection<Boat> Boats { get; set; } = new List<Boat>();
    public virtual ICollection<BoatSpec> BoatSpecs { get; set; } = new List<BoatSpec>();
    public string LocalizedName
    {
        get
        {
            var culture = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;

            if (culture == "tr")
            {
                return NameTr;
            }
            return NameEn;
        }

    }
}

public class SpecEntityTypeConfiguration : IEntityTypeConfiguration<Spec>
{
    public void Configure(EntityTypeBuilder<Spec> builder)
    {
        builder.HasData(
new Spec { Id = Guid.Parse("{DA17D13C-0B26-4858-A9CB-B9582BDB74BE}"), NameTr = "Yapım Yılı", NameEn = "Year of Construction" },
new Spec { Id = Guid.Parse("{61108CAC-C37E-4F69-9ECF-EC55EDA48E96}"), NameTr = "Wc-Shower", NameEn = "WC-Shower" },
new Spec { Id = Guid.Parse("{DDB0DC04-930D-453A-BF1D-2B0E674A1994}"), NameTr = "Su Kapasitesi", NameEn = "Water Capacity" },
new Spec { Id = Guid.Parse("{EC25EEAB-C424-477A-9B4A-A3B4F5C9E361}"), NameTr = "Yelkenin Sarılması", NameEn = "Furling Genoa" },
new Spec { Id = Guid.Parse("{4E46CD80-163B-4718-A286-DDC378D45C13}"), NameTr = "Motor", NameEn = "Engine" },
new Spec { Id = Guid.Parse("{A07CB0F9-4C39-4F57-9405-77BF8D6E1D93}"), NameTr = "Bayrak", NameEn = "Flag" },
new Spec { Id = Guid.Parse("{5D87B59A-97BC-4AFB-955B-175E6556E429}"), NameTr = "Taslak", NameEn = "Draft" },
new Spec { Id = Guid.Parse("{6E0DB24F-E1EB-46EB-86B1-CDE121C1CF24}"), NameTr = "Yakıt Kapasitesi", NameEn = "Fuel Capacity" },
new Spec { Id = Guid.Parse("{675BD427-8434-4F0A-96F5-9C7961BA0941}"), NameTr = "Klasik Ana Yelken", NameEn = "Classic Mainsail" },
new Spec { Id = Guid.Parse("{A7BC34AC-F43F-4E67-B59B-40EF07A31592}"), NameTr = "Elektrikli Winch", NameEn = "Electric Winch" },
new Spec { Id = Guid.Parse("{E51798A7-2047-4EF3-8DB3-4AB87CC5D0B9}"), NameTr = "Model", NameEn = "Model" },
new Spec { Id = Guid.Parse("{41E722C1-BFB5-48F3-B706-B99ECF754EBF}"), NameTr = "Jeneratör", NameEn = "Generator" },
new Spec { Id = Guid.Parse("{B7A326A4-7C04-4382-A667-AA0A062C4972}"), NameTr = "Yakıt Tankı", NameEn = "Fuel Tank" },
new Spec { Id = Guid.Parse("{E0A49834-40AE-487F-AE8B-A33194CC9D1C}"), NameTr = "Çift Kabin", NameEn = "Double Cabin" },
new Spec { Id = Guid.Parse("{2A48445D-384E-4FD9-9100-60DF49125E1A}"), NameTr = "Temiz Su Tankı", NameEn = "Fresh Water Tank" },
new Spec { Id = Guid.Parse("{F713FB86-A965-4BAD-8E5E-CDE3714F2E0E}"), NameTr = "Ana Kabin", NameEn = "Master Cabin" },
new Spec { Id = Guid.Parse("{F0D7957C-C779-4A6A-A9E8-07E7D097C164}"), NameTr = "Ana Yelken", NameEn = "Mainsail" },
new Spec { Id = Guid.Parse("{A0710B91-2461-41B6-A36D-827E7E68C21A}"), NameTr = "Yapıldığı Yıl", NameEn = "Year Built" },
new Spec { Id = Guid.Parse("{E7A5E5F6-C5D5-43BE-A7BC-68897D7977C1}"), NameTr = "Su Çekilmesi", NameEn = "Draft" },
new Spec { Id = Guid.Parse("{48FE5920-1DD1-4583-BF74-FBAC08209BA9}"), NameTr = "Sarılabilen Ana Yelken", NameEn = "Furling Mainsail" },
new Spec { Id = Guid.Parse("{D02087D8-7684-4B78-9D1A-7E70E092CBEB}"), NameTr = "İkiz Kabin", NameEn = "Twin Cabin" },
new Spec { Id = Guid.Parse("{66D2FE7F-1319-455C-B1C6-79B66B5A4420}"), NameTr = "Harita Plotteri", NameEn = "Chartplotter" }
            );
    }
}