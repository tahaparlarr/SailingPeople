using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace SailingPeople.Domain;

public class Facility
{
    public Guid Id { get; set; }
    public Guid FacilityId { get; set; }
    public required string NameTr { get; set; }
    public required string NameEn { get; set; }
    public virtual ICollection<Boat> Boats { get; set; } = new List<Boat>();
}

public class FacilityEntityTypeConfiguration : IEntityTypeConfiguration<Facility>
{
    public void Configure(EntityTypeBuilder<Facility> builder)
    {
        builder.HasData(
 new Facility { Id = Guid.Parse("{F00C470F-0595-4C35-AF61-964E15CA4335}"), NameTr = "Sıcak Su", NameEn = "Hot water" },
    new Facility { Id = Guid.Parse("{3AF46FCC-D59B-407F-B72F-669730089F9C}"), NameTr = "Sabun / Şampuan", NameEn = "Soap / Shampoo" },
    new Facility { Id = Guid.Parse("{C8F70DA8-6E5A-4A96-A8ED-E50B282636DE}"), NameTr = "Havlu / Çarşaf", NameEn = "Towel / Sheet" },
    new Facility { Id = Guid.Parse("{BC41EDB3-0AE7-4205-8E4E-CCE9A5A34B0E}"), NameTr = "Tuvalet", NameEn = "Toilet" },
    new Facility { Id = Guid.Parse("{75E90B41-8A80-4FCE-8BD9-4840B1169F91}"), NameTr = "Duş", NameEn = "Shower" },
    new Facility { Id = Guid.Parse("{DB35E9F6-419D-4C9E-A200-2C9902F9D148}"), NameTr = "Buzdolabı", NameEn = "Freezer" },
    new Facility { Id = Guid.Parse("{16DA6ACA-5F9E-43C8-B2D7-40CB02ED4BDF}"), NameTr = "Bimini Üstü", NameEn = "Biminitop" },
    new Facility { Id = Guid.Parse("{5F8EFC71-7086-451A-8014-D8064BB07A76}"), NameTr = "Teak Güverte", NameEn = "Teak Deck" },
    new Facility { Id = Guid.Parse("{96B23F3C-BC3E-4260-8A21-8392A44E482F}"), NameTr = "Pervane İleri Yön", NameEn = "Bow Thruster" },
    new Facility { Id = Guid.Parse("{2681BEFA-CACB-4372-B385-B701D8D8705F}"), NameTr = "Sprey Çadırı", NameEn = "Sprayhood" },
    new Facility { Id = Guid.Parse("{3A325EBD-361D-4859-8125-9656796A20DA}"), NameTr = "Güneş Paneli", NameEn = "Solar Panel" },
    new Facility { Id = Guid.Parse("{D97179EF-F17C-4CCA-A9D2-7AFB13C715F3}"), NameTr = "GPS", NameEn = "GPS" },
    new Facility { Id = Guid.Parse("{D2337F7F-581C-4DF3-966F-D40EF528EFCC}"), NameTr = "Televizyon / DVD", NameEn = "TV/DVD" },
    new Facility { Id = Guid.Parse("{ED3153D1-BD7D-4C6D-8E77-31677244351C}"), NameTr = "Müzik Sistemi AUX", NameEn = "Music System AUX" },
    new Facility { Id = Guid.Parse("{150D1179-8548-47C4-AFF4-E4CA001B1ED1}"), NameTr = "Klima", NameEn = "Air Conditioning" },
    new Facility { Id = Guid.Parse("{91CB398E-AAE9-4D71-AD39-138ACA252B25}"), NameTr = "Internet Bağlantısı", NameEn = "Internet connection" },
    new Facility { Id = Guid.Parse("{F46B0B14-9719-46CA-B460-660E6A22F2DD}"), NameTr = "Jacuzzi", NameEn = "Jacuzzi" },
    new Facility { Id = Guid.Parse("{79BBB137-57B4-4FC9-8E2E-DB874F05B9C8}"), NameTr = "Dış Duş", NameEn = "Outside Shower" },
    new Facility { Id = Guid.Parse("{E6D0C77B-714B-455F-8498-2433DBFAE51A}"), NameTr = "Yüzme Merdiveni", NameEn = "Swimming Ladder" },
    new Facility { Id = Guid.Parse("{DCB774D6-77BA-4090-85FA-BCE964E02BBC}"), NameTr = "Şemsiye", NameEn = "Canopy" },
    new Facility { Id = Guid.Parse("{339D8F62-0712-4D39-9A94-C0DBA1AEEEED}"), NameTr = "Telefon", NameEn = "Telephone" },
    new Facility { Id = Guid.Parse("{E7F5594F-41EB-444F-80EA-2CD05CDFFBEA}"), NameTr = "Servis Botu", NameEn = "Service Boat" },
    new Facility { Id = Guid.Parse("{B6E2AA72-3CE9-4BED-96CB-B5A6AD0F1385}"), NameTr = "Kano", NameEn = "Canoe" },
    new Facility { Id = Guid.Parse("{2F41793A-1D95-4006-8EEB-107EA418BC9C}"), NameTr = "Derinlik Ölçümü", NameEn = "Depth Sounding" },
    new Facility { Id = Guid.Parse("{88F8F14F-8A9A-45A4-954D-0FF7F1D8265F}"), NameTr = "Şnorkel ve Balık Avı Ekipmanları", NameEn = "Snorkeling and Fishing Equipment" },
    new Facility { Id = Guid.Parse("{D16AC7AB-2C8E-4AE2-8A0F-F0F5A9397123}"), NameTr = "Kano", NameEn = "Canoe" },
    new Facility { Id = Guid.Parse("{FC02F6E5-1EEC-4B1F-81E5-8AA4C95190F9}"), NameTr = "Servis Botu", NameEn = "Service Boat" },
    new Facility { Id = Guid.Parse("{99D9F57F-ABF0-4D9F-85B5-DB8A045C2B9C}"), NameTr = "Bulaşık Makinesi", NameEn = "Dishwasher" },
    new Facility { Id = Guid.Parse("{57C2B597-BBB6-46F9-BABF-5283DBA0A65A}"), NameTr = "Dıştan Takma Motor", NameEn = "Outboard Engine" },
    new Facility { Id = Guid.Parse("{987EE924-82A0-44E3-B207-4DAED6E59F72}"), NameTr = "Bar", NameEn = "Bar" },
    new Facility { Id = Guid.Parse("{78A8F2D1-9E2F-45E7-8DC2-8E1D640869C2}"), NameTr = "Uydu Bağlantısı", NameEn = "Satellite Link" },
    new Facility { Id = Guid.Parse("{D59D28E3-319D-4682-8E59-67667D947A83}"), NameTr = "Otomatik Pilot", NameEn = "Autopilot" },
    new Facility { Id = Guid.Parse("{AD91B440-9E12-4D6C-926B-7887397D1A79}"), NameTr = "Navtek (Uydu Hava Raporu)", NameEn = "Navtek (Satellite Weather Report)" }
            );
    }
}