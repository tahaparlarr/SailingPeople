using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace SailingPeople.Domain;
public class Facility
{
    public Guid Id { get; set; }
    public Guid FacilityCategoryId { get; set; }
    public required string NameTr { get; set; }
    public required string NameEn { get; set; }
    public virtual FacilityCategory FacilityCategory { get; set; }
    public virtual ICollection<Boat> Boats { get; set; } = new List<Boat>();
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

public class FacilityEntityTypeConfiguration : IEntityTypeConfiguration<Facility>
{
    public void Configure(EntityTypeBuilder<Facility> builder)
    {
        builder.HasData(
    new Facility
    {
        Id = Guid.Parse("{F00C470F-0595-4C35-AF61-964E15CA4335}"),
        NameTr = "Sıcak Su",
        NameEn = "Hot Water",
        FacilityCategoryId = Guid.Parse("{A1E93A3D-6F42-4A15-A0C8-ABF80693F9BC}")
    },

new Facility
{
    Id = Guid.Parse("{3AF46FCC-D59B-407F-B72F-669730089F9C}"),
    NameTr = "Sabun / Şampuan",
    NameEn = "Soap / Shampoo",
    FacilityCategoryId = Guid.Parse("{A1E93A3D-6F42-4A15-A0C8-ABF80693F9BC}")
},

new Facility
{
    Id = Guid.Parse("{C8F70DA8-6E5A-4A96-A8ED-E50B282636DE}"),
    NameTr = "Havlu / Çarşaf",
    NameEn = "Towel / Sheet",
    FacilityCategoryId = Guid.Parse("{A1E93A3D-6F42-4A15-A0C8-ABF80693F9BC}")
},

new Facility
{
    Id = Guid.Parse("{BC41EDB3-0AE7-4205-8E4E-CCE9A5A34B0E}"),
    NameTr = "Tuvalet",
    NameEn = "Toilet",
    FacilityCategoryId = Guid.Parse("{A1E93A3D-6F42-4A15-A0C8-ABF80693F9BC}")
},

new Facility
{
    Id = Guid.Parse("{75E90B41-8A80-4FCE-8BD9-4840B1169F91}"),
    NameTr = "Duş",
    NameEn = "Shower",
    FacilityCategoryId = Guid.Parse("{A1E93A3D-6F42-4A15-A0C8-ABF80693F9BC}")
},

new Facility
{
    Id = Guid.Parse("{DB35E9F6-419D-4C9E-A200-2C9902F9D148}"),
    NameTr = "Buzdolabı",
    NameEn = "Refrigerator",
    FacilityCategoryId = Guid.Parse("{1DB7A378-5E4E-4C61-B0A2-F7DAB56F6D51}")
},

new Facility
{
    Id = Guid.Parse("{16DA6ACA-5F9E-43C8-B2D7-40CB02ED4BDF}"),
    NameTr = "Bimini Üstü",
    NameEn = "Bimini Top",
    FacilityCategoryId = Guid.Parse("{A3F47C0E-30A6-4C89-A4A0-5AC20551D595}")
},

new Facility
{
    Id = Guid.Parse("{5F8EFC71-7086-451A-8014-D8064BB07A76}"),
    NameTr = "Teak Güverte",
    NameEn = "Teak Deck",
    FacilityCategoryId = Guid.Parse("{A3F47C0E-30A6-4C89-A4A0-5AC20551D595}")
},

new Facility
{
    Id = Guid.Parse("{96B23F3C-BC3E-4260-8A21-8392A44E482F}"),
    NameTr = "Baş Pervane",
    NameEn = "Bow Thruster",
    FacilityCategoryId = Guid.Parse("{E00C8365-914D-4874-99B5-6C43D6A96717}")
},

new Facility
{
    Id = Guid.Parse("{2681BEFA-CACB-4372-B385-B701D8D8705F}"),
    NameTr = "Sprey Çadırı",
    NameEn = "Sprayhood",
    FacilityCategoryId = Guid.Parse("{A3F47C0E-30A6-4C89-A4A0-5AC20551D595}")
},

new Facility
{
    Id = Guid.Parse("{3A325EBD-361D-4859-8125-9656796A20DA}"),
    NameTr = "Güneş Paneli",
    NameEn = "Solar Panel",
    FacilityCategoryId = Guid.Parse("{A3F47C0E-30A6-4C89-A4A0-5AC20551D595}")
},

new Facility
{
    Id = Guid.Parse("{D97179EF-F17C-4CCA-A9D2-7AFB13C715F3}"),
    NameTr = "GPS",
    NameEn = "GPS",
    FacilityCategoryId = Guid.Parse("{A3F47C0E-30A6-4C89-A4A0-5AC20551D595}")
},

new Facility
{
    Id = Guid.Parse("{D2337F7F-581C-4DF3-966F-D40EF528EFCC}"),
    NameTr = "Televizyon / DVD",
    NameEn = "TV / DVD",
    FacilityCategoryId = Guid.Parse("{A3F47C0E-30A6-4C89-A4A0-5AC20551D595}")
},

new Facility
{
    Id = Guid.Parse("{ED3153D1-BD7D-4C6D-8E77-31677244351C}"),
    NameTr = "Müzik Sistemi AUX",
    NameEn = "Music System AUX",
    FacilityCategoryId = Guid.Parse("{A3F47C0E-30A6-4C89-A4A0-5AC20551D595}")
},

new Facility
{
    Id = Guid.Parse("{150D1179-8548-47C4-AFF4-E4CA001B1ED1}"),
    NameTr = "Klima",
    NameEn = "Air Conditioning",
    FacilityCategoryId = Guid.Parse("{B2F7E13B-001A-48BB-B4EF-B387C5D90A4C}")
},

new Facility
{
    Id = Guid.Parse("{91CB398E-AAE9-4D71-AD39-138ACA252B25}"),
    NameTr = "İnternet Bağlantısı",
    NameEn = "Internet Connection",
    FacilityCategoryId = Guid.Parse("{B2F7E13B-001A-48BB-B4EF-B387C5D90A4C}")
},

new Facility
{
    Id = Guid.Parse("{F46B0B14-9719-46CA-B460-660E6A22F2DD}"),
    NameTr = "Jacuzzi",
    NameEn = "Jacuzzi",
    FacilityCategoryId = Guid.Parse("{B2F7E13B-001A-48BB-B4EF-B387C5D90A4C}")
},

new Facility
{
    Id = Guid.Parse("{79BBB137-57B4-4FC9-8E2E-DB874F05B9C8}"),
    NameTr = "Dış Duş",
    NameEn = "Outside Shower",
    FacilityCategoryId = Guid.Parse("{B2F7E13B-001A-48BB-B4EF-B387C5D90A4C}")
},

new Facility
{
    Id = Guid.Parse("{E6D0C77B-714B-455F-8498-2433DBFAE51A}"),
    NameTr = "Yüzme Merdiveni",
    NameEn = "Swim Ladder",
    FacilityCategoryId = Guid.Parse("{B2F7E13B-001A-48BB-B4EF-B387C5D90A4C}")
},

new Facility
{
    Id = Guid.Parse("{DCB774D6-77BA-4090-85FA-BCE964E02BBC}"),
    NameTr = "Şemsiye",
    NameEn = "Canopy",
    FacilityCategoryId = Guid.Parse("{B2F7E13B-001A-48BB-B4EF-B387C5D90A4C}")
},

new Facility
{
    Id = Guid.Parse("{339D8F62-0712-4D39-9A94-C0DBA1AEEEED}"),
    NameTr = "Telefon",
    NameEn = "Telephone",
    FacilityCategoryId = Guid.Parse("{A3F47C0E-30A6-4C89-A4A0-5AC20551D595}")
},

new Facility
{
    Id = Guid.Parse("{E7F5594F-41EB-444F-80EA-2CD05CDFFBEA}"),
    NameTr = "Servis Botu",
    NameEn = "Tender",
    FacilityCategoryId = Guid.Parse("{A3F47C0E-30A6-4C89-A4A0-5AC20551D595}")
},

new Facility
{
    Id = Guid.Parse("{B6E2AA72-3CE9-4BED-96CB-B5A6AD0F1385}"),
    NameTr = "Kano",
    NameEn = "Canoe",
    FacilityCategoryId = Guid.Parse("{C1C48A44-6B02-4E6A-95C5-1D262788B7F0}")
},

new Facility
{
    Id = Guid.Parse("{2F41793A-1D95-4006-8EEB-107EA418BC9C}"),
    NameTr = "Derinlik Ölçümü",
    NameEn = "Depth Sounder",
    FacilityCategoryId = Guid.Parse("{C1C48A44-6B02-4E6A-95C5-1D262788B7F0}")
},

new Facility
{
    Id = Guid.Parse("{88F8F14F-8A9A-45A4-954D-0FF7F1D8265F}"),
    NameTr = "Şnorkel ve Balık Avı Ekipmanları",
    NameEn = "Snorkeling and Fishing Equipment",
    FacilityCategoryId = Guid.Parse("{C1C48A44-6B02-4E6A-95C5-1D262788B7F0}")
},

new Facility
{
    Id = Guid.Parse("{99D9F57F-ABF0-4D9F-85B5-DB8A045C2B9C}"),
    NameTr = "Bulaşık Makinesi",
    NameEn = "Dishwasher",
    FacilityCategoryId = Guid.Parse("{1DB7A378-5E4E-4C61-B0A2-F7DAB56F6D51}")
},

new Facility
{
    Id = Guid.Parse("{57C2B597-BBB6-46F9-BABF-5283DBA0A65A}"),
    NameTr = "Dıştan Takma Motor",
    NameEn = "Outboard Engine",
    FacilityCategoryId = Guid.Parse("{A3F47C0E-30A6-4C89-A4A0-5AC20551D595}")
},

new Facility
{
    Id = Guid.Parse("{987EE924-82A0-44E3-B207-4DAED6E59F72}"),
    NameTr = "Bar",
    NameEn = "Bar",
    FacilityCategoryId = Guid.Parse("{B2F7E13B-001A-48BB-B4EF-B387C5D90A4C}")
},

new Facility
{
    Id = Guid.Parse("{78A8F2D1-9E2F-45E7-8DC2-8E1D640869C2}"),
    NameTr = "Uydu Bağlantısı",
    NameEn = "Satellite Connection",
    FacilityCategoryId = Guid.Parse("{A3F47C0E-30A6-4C89-A4A0-5AC20551D595}")
},

new Facility
{
    Id = Guid.Parse("{D59D28E3-319D-4682-8E59-67667D947A83}"),
    NameTr = "Otomatik Pilot",
    NameEn = "Autopilot",
    FacilityCategoryId = Guid.Parse("{E00C8365-914D-4874-99B5-6C43D6A96717}")
},

new Facility
{
    Id = Guid.Parse("{AD91B440-9E12-4D6C-926B-7887397D1A79}"),
    NameTr = "Navtex (Uydu Hava Raporu)",
    NameEn = "Navtex (Satellite Weather Report)",
    FacilityCategoryId = Guid.Parse("{E00C8365-914D-4874-99B5-6C43D6A96717}")
},

new Facility
{
    Id = Guid.Parse("{D5BD72E7-A67D-4731-9694-87B0E86DE2A2}"),
    NameTr = "Servis Botu",
    NameEn = "Service Boat",
    FacilityCategoryId = Guid.Parse("{A3F47C0E-30A6-4C89-A4A0-5AC20551D595}")
},

new Facility
{
    Id = Guid.Parse("{144E94AA-6D38-45D1-BB8E-678019DE37FD}"),
    NameTr = "Radar",
    NameEn = "Radar",
    FacilityCategoryId = Guid.Parse("{E00C8365-914D-4874-99B5-6C43D6A96717}")
},

new Facility
{
    Id = Guid.Parse("{D3CD6394-3222-46DF-A677-C9302E9499BF}"),
    NameTr = "VHF",
    NameEn = "VHF",
    FacilityCategoryId = Guid.Parse("{E00C8365-914D-4874-99B5-6C43D6A96717}")
},

new Facility
{
    Id = Guid.Parse("{3E5E14C8-A9FA-4B54-A4EE-EC82189B10AF}"),
    NameTr = "Buz Makinesi",
    NameEn = "Ice Machine",
    FacilityCategoryId = Guid.Parse("{1DB7A378-5E4E-4C61-B0A2-F7DAB56F6D51}")
},

new Facility
{
    Id = Guid.Parse("{DC88F861-098D-4152-B101-A8157C803DAF}"),
    NameTr = "Klasik Ana Yelken",
    NameEn = "Classic Mainsail",
    FacilityCategoryId = Guid.Parse("{A3F47C0E-30A6-4C89-A4A0-5AC20551D595}")
},
new Facility
{
    Id = Guid.Parse("{A47E35DC-69AC-46BF-BFF5-43E9D26BE416}"),
    NameTr = "Tamir Kitleri",
    NameEn = "Repair Kits",
    FacilityCategoryId = Guid.Parse("{C1C48A44-6B02-4E6A-95C5-1D262788B7F0}")
},

new Facility
{
    Id = Guid.Parse("{3ED945B9-DE82-461D-9349-6638DD2A75B4}"),
    NameTr = "Yangın Söndürücü",
    NameEn = "Fire Extinguisher",
    FacilityCategoryId = Guid.Parse("{C1C48A44-6B02-4E6A-95C5-1D262788B7F0}")
},

new Facility
{
    Id = Guid.Parse("{2F700CE8-3625-4C97-8CA5-1A6FF658FB64}"),
    NameTr = "Kahve Makinesi",
    NameEn = "Coffee Machine",
    FacilityCategoryId = Guid.Parse("{1DB7A378-5E4E-4C61-B0A2-F7DAB56F6D51}")
},

new Facility
{
    Id = Guid.Parse("{51D8BE6D-0990-41B7-9754-1B64860FDE74}"),
    NameTr = "Navigasyon",
    NameEn = "Navigation",
    FacilityCategoryId = Guid.Parse("{E00C8365-914D-4874-99B5-6C43D6A96717}")
},
new Facility
{
    Id = Guid.Parse("{6F91253D-9F4D-475A-8F4A-8F29C27DB56A}"),
    NameTr = "Ocak",
    NameEn = "Stove",
    FacilityCategoryId = Guid.Parse("{1DB7A378-5E4E-4C61-B0A2-F7DAB56F6D51}")
},
new Facility
{
    Id = Guid.Parse("{B7C347B2-0F5D-48DC-A432-34E0D56B0972}"),
    NameTr = "Dondurucu",
    NameEn = "Freezer",
    FacilityCategoryId = Guid.Parse("{1DB7A378-5E4E-4C61-B0A2-F7DAB56F6D51}")
},
new Facility
{
    Id = Guid.Parse("{3C61755B-6A85-4A35-BD67-2E6A3A161E97}"),
    NameTr = "Isıtıcı",
    NameEn = "Heater",
    FacilityCategoryId = Guid.Parse("{1DB7A378-5E4E-4C61-B0A2-F7DAB56F6D51}")
},
new Facility
{
    Id = Guid.Parse("{4E41E85A-7FB3-45E7-832D-51A63F06034E}"),
    NameTr = "Mutfak Malzemeleri",
    NameEn = "Kitchen Utensils",
    FacilityCategoryId = Guid.Parse("{1DB7A378-5E4E-4C61-B0A2-F7DAB56F6D51}")
},
new Facility
{
    Id = Guid.Parse("{A0338A12-ADA7-4B99-BEC5-8B1A0D9FB9A9}"),
    NameTr = "Mikrodalga Fırın",
    NameEn = "Microwave Oven",
    FacilityCategoryId = Guid.Parse("{1DB7A378-5E4E-4C61-B0A2-F7DAB56F6D51}")
},
new Facility
{
    Id = Guid.Parse("{1B2A1D64-87D3-49DC-927D-0C44E8D42E9C}"),
    NameTr = "Fırın",
    NameEn = "Oven",
    FacilityCategoryId = Guid.Parse("{1DB7A378-5E4E-4C61-B0A2-F7DAB56F6D51}")
},

new Facility
{
    Id = Guid.Parse("{6D962A0B-9231-49E5-82B7-03516E3B48D7}"),
    NameTr = "Atık Tankı",
    NameEn = "Waste Tank",
    FacilityCategoryId = Guid.Parse("{A1E93A3D-6F42-4A15-A0C8-ABF80693F9BC}")
},
new Facility
{
    Id = Guid.Parse("{9E671BAF-3D9E-4C2D-9196-8B694E22787A}"),
    NameTr = "Mangal",
    NameEn = "Grill",
    FacilityCategoryId = Guid.Parse("{1DB7A378-5E4E-4C61-B0A2-F7DAB56F6D51}")
},
new Facility
{
    Id = Guid.Parse("{26A6D23E-8D6B-4C50-9D8F-08BB9A388FF8}"),
    NameTr = "Güneşlenme Yatakları",
    NameEn = "Sunbathing Beds",
    FacilityCategoryId = Guid.Parse("{A3F47C0E-30A6-4C89-A4A0-5AC20551D595}")
},
new Facility
{
    Id = Guid.Parse("{4EFA6FF3-7984-4E59-B23F-7F3F3873D687}"),
    NameTr = "Crew Kabin",
    NameEn = "Crew Cabin",
    FacilityCategoryId = Guid.Parse("{B2F7E13B-001A-48BB-B4EF-B387C5D90A4C}")
},
new Facility
{
    Id = Guid.Parse("{F97F6D36-8100-4721-917F-0F5716FDF8A9}"),
    NameTr = "Yastıklar ve Battaniyeler",
    NameEn = "Pillows and Blankets",
    FacilityCategoryId = Guid.Parse("{B2F7E13B-001A-48BB-B4EF-B387C5D90A4C}")
},
new Facility
{
    Id = Guid.Parse("{F2E6F7F3-A056-4552-8FC7-72AA11D23E3E}"),
    NameTr = "Lavabo",
    NameEn = "Sink",
    FacilityCategoryId = Guid.Parse("{A1E93A3D-6F42-4A15-A0C8-ABF80693F9BC}")
},
new Facility
{
    Id = Guid.Parse("{8D2A1E78-1A79-4F39-92C5-B4F26519BCB1}"),
    NameTr = "Havlu",
    NameEn = "Towel",
    FacilityCategoryId = Guid.Parse("{B2F7E13B-001A-48BB-B4EF-B387C5D90A4C}")
},
new Facility
{
    Id = Guid.Parse("{C3F93F88-5E5D-4635-9149-17EE18A0140C}"),
    NameTr = "Salon GPS Plotter",
    NameEn = "Salon GPS Plotter",
    FacilityCategoryId = Guid.Parse("{C1C48A44-6B02-4E6A-95C5-1D262788B7F0}")
},
new Facility
{
    Id = Guid.Parse("{A67F8E7F-A53A-43E3-90B9-D88DDE8C9D28}"),
    NameTr = "Dingi",
    NameEn = "Dinghy",
    FacilityCategoryId = Guid.Parse("{A3F47C0E-30A6-4C89-A4A0-5AC20551D595}")
},
new Facility
{
    Id = Guid.Parse("{548506FE-B619-4F76-B0AD-2F33D5102D85}"),
    NameTr = "Jeneratör",
    NameEn = "Generator",
    FacilityCategoryId = Guid.Parse("{C1C48A44-6B02-4E6A-95C5-1D262788B7F0}")
},
new Facility
{
    Id = Guid.Parse("{A1B45A2B-9C31-4D53-9009-7416DA5E1B0D}"),
    NameTr = "Güneş Panelleri",
    NameEn = "Solar Panels",
    FacilityCategoryId = Guid.Parse("{C1C48A44-6B02-4E6A-95C5-1D262788B7F0}")
},
new Facility
{
    Id = Guid.Parse("{DCC1A4EC-3208-48F9-9F67-917FD0802C09}"),
    NameTr = "Electric Winches",
    NameEn = "Electric Winches",
    FacilityCategoryId = Guid.Parse("{C1C48A44-6B02-4E6A-95C5-1D262788B7F0}")
},
new Facility
{
    Id = Guid.Parse("{4A489577-9462-46B2-925C-CE21153C1730}"),
    NameTr = "Inverter",
    NameEn = "Inverter",
    FacilityCategoryId = Guid.Parse("{C1C48A44-6B02-4E6A-95C5-1D262788B7F0}")
},
new Facility
{
    Id = Guid.Parse("{F5B1467C-BD30-4D28-A9E0-B5B4E42DB3DB}"),
    NameTr = "Kokpit Hoparlörleri",
    NameEn = "Cockpit Speakers",
    FacilityCategoryId = Guid.Parse("{C1C48A44-6B02-4E6A-95C5-1D262788B7F0}")
},
new Facility
{
    Id = Guid.Parse("{C983405D-9A7E-49FB-B5B3-4B06B04F1A44}"),
    NameTr = "Ses Sistemi",
    NameEn = "Sound System",
    FacilityCategoryId = Guid.Parse("{C1C48A44-6B02-4E6A-95C5-1D262788B7F0}")
}


        );
    }
}