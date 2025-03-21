using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SailingPeople.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NameTr = table.Column<string>(type: "text", nullable: false),
                    NameEn = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FacilityCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NameTr = table.Column<string>(type: "text", nullable: false),
                    NameEn = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilityCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NameTr = table.Column<string>(type: "text", nullable: false),
                    NameEn = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Boats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", unicode: false, nullable: true),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    RentType = table.Column<int>(type: "integer", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    MayToOctoberPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    JunePrice = table.Column<decimal>(type: "numeric", nullable: false),
                    JulyToAugustPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    SeptemberPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    Width = table.Column<float>(type: "real", nullable: false),
                    Length = table.Column<float>(type: "real", nullable: false),
                    Guest = table.Column<int>(type: "integer", nullable: false),
                    Cabin = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Boats_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Facilities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FacilityId = table.Column<Guid>(type: "uuid", nullable: false),
                    NameTr = table.Column<string>(type: "text", nullable: false),
                    NameEn = table.Column<string>(type: "text", nullable: false),
                    FacilityCategoryId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Facilities_FacilityCategory_FacilityCategoryId",
                        column: x => x.FacilityCategoryId,
                        principalTable: "FacilityCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BoatImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BoatId = table.Column<Guid>(type: "uuid", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoatImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BoatImages_Boats_BoatId",
                        column: x => x.BoatId,
                        principalTable: "Boats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BoatSpecs",
                columns: table => new
                {
                    BoatId = table.Column<Guid>(type: "uuid", nullable: false),
                    SpecId = table.Column<Guid>(type: "uuid", nullable: false),
                    ValueTr = table.Column<string>(type: "text", nullable: false),
                    ValueEn = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoatSpecs", x => new { x.BoatId, x.SpecId });
                    table.ForeignKey(
                        name: "FK_BoatSpecs_Boats_BoatId",
                        column: x => x.BoatId,
                        principalTable: "Boats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoatSpecs_Specs_SpecId",
                        column: x => x.SpecId,
                        principalTable: "Specs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BoatFacility",
                columns: table => new
                {
                    BoatsId = table.Column<Guid>(type: "uuid", nullable: false),
                    FacilitiesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoatFacility", x => new { x.BoatsId, x.FacilitiesId });
                    table.ForeignKey(
                        name: "FK_BoatFacility_Boats_BoatsId",
                        column: x => x.BoatsId,
                        principalTable: "Boats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoatFacility_Facilities_FacilitiesId",
                        column: x => x.FacilitiesId,
                        principalTable: "Facilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "NameEn", "NameTr" },
                values: new object[,]
                {
                    { new Guid("4cdf4cd0-dda7-41ed-bf55-76a2c5dbf0a0"), "Catamaran", "Katamaran" },
                    { new Guid("9a242089-51bc-4f73-b2d5-033c4e20003f"), "Gulet", "Gulet" },
                    { new Guid("9ab03277-4a7f-401e-9677-02d6853227f0"), "Motor Yacht", "Motor Yat" },
                    { new Guid("a2092ee2-5218-4846-a716-024b57c1989e"), "Sailing Yacht", "Yelkenli" }
                });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "Id", "FacilityCategoryId", "FacilityId", "NameEn", "NameTr" },
                values: new object[,]
                {
                    { new Guid("150d1179-8548-47c4-aff4-e4ca001b1ed1"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Air Conditioning", "Klima" },
                    { new Guid("16da6aca-5f9e-43c8-b2d7-40cb02ed4bdf"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Biminitop", "Bimini Üstü" },
                    { new Guid("2681befa-cacb-4372-b385-b701d8d8705f"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Sprayhood", "Sprey Çadırı" },
                    { new Guid("2f41793a-1d95-4006-8eeb-107ea418bc9c"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Depth Sounding", "Derinlik Ölçümü" },
                    { new Guid("339d8f62-0712-4d39-9a94-c0dba1aeeeed"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Telephone", "Telefon" },
                    { new Guid("3a325ebd-361d-4859-8125-9656796a20da"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Solar Panel", "Güneş Paneli" },
                    { new Guid("3af46fcc-d59b-407f-b72f-669730089f9c"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Soap / Shampoo", "Sabun / Şampuan" },
                    { new Guid("57c2b597-bbb6-46f9-babf-5283dba0a65a"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Outboard Engine", "Dıştan Takma Motor" },
                    { new Guid("5f8efc71-7086-451a-8014-d8064bb07a76"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Teak Deck", "Teak Güverte" },
                    { new Guid("75e90b41-8a80-4fce-8bd9-4840b1169f91"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Shower", "Duş" },
                    { new Guid("78a8f2d1-9e2f-45e7-8dc2-8e1d640869c2"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Satellite Link", "Uydu Bağlantısı" },
                    { new Guid("79bbb137-57b4-4fc9-8e2e-db874f05b9c8"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Outside Shower", "Dış Duş" },
                    { new Guid("88f8f14f-8a9a-45a4-954d-0ff7f1d8265f"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Snorkeling and Fishing Equipment", "Şnorkel ve Balık Avı Ekipmanları" },
                    { new Guid("91cb398e-aae9-4d71-ad39-138aca252b25"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Internet connection", "Internet Bağlantısı" },
                    { new Guid("96b23f3c-bc3e-4260-8a21-8392a44e482f"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Bow Thruster", "Pervane İleri Yön" },
                    { new Guid("987ee924-82a0-44e3-b207-4daed6e59f72"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Bar", "Bar" },
                    { new Guid("99d9f57f-abf0-4d9f-85b5-db8a045c2b9c"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Dishwasher", "Bulaşık Makinesi" },
                    { new Guid("ad91b440-9e12-4d6c-926b-7887397d1a79"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Navtek (Satellite Weather Report)", "Navtek (Uydu Hava Raporu)" },
                    { new Guid("b6e2aa72-3ce9-4bed-96cb-b5a6ad0f1385"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Canoe", "Kano" },
                    { new Guid("bc41edb3-0ae7-4205-8e4e-cce9a5a34b0e"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Toilet", "Tuvalet" },
                    { new Guid("c8f70da8-6e5a-4a96-a8ed-e50b282636de"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Towel / Sheet", "Havlu / Çarşaf" },
                    { new Guid("d16ac7ab-2c8e-4ae2-8a0f-f0f5a9397123"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Canoe", "Kano" },
                    { new Guid("d2337f7f-581c-4df3-966f-d40ef528efcc"), null, new Guid("00000000-0000-0000-0000-000000000000"), "TV/DVD", "Televizyon / DVD" },
                    { new Guid("d59d28e3-319d-4682-8e59-67667d947a83"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Autopilot", "Otomatik Pilot" },
                    { new Guid("d97179ef-f17c-4cca-a9d2-7afb13c715f3"), null, new Guid("00000000-0000-0000-0000-000000000000"), "GPS", "GPS" },
                    { new Guid("db35e9f6-419d-4c9e-a200-2c9902f9d148"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Freezer", "Buzdolabı" },
                    { new Guid("dcb774d6-77ba-4090-85fa-bce964e02bbc"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Canopy", "Şemsiye" },
                    { new Guid("e6d0c77b-714b-455f-8498-2433dbfae51a"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Swimming Ladder", "Yüzme Merdiveni" },
                    { new Guid("e7f5594f-41eb-444f-80ea-2cd05cdffbea"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Service Boat", "Servis Botu" },
                    { new Guid("ed3153d1-bd7d-4c6d-8e77-31677244351c"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Music System AUX", "Müzik Sistemi AUX" },
                    { new Guid("f00c470f-0595-4c35-af61-964e15ca4335"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Hot water", "Sıcak Su" },
                    { new Guid("f46b0b14-9719-46ca-b460-660e6a22f2dd"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Jacuzzi", "Jacuzzi" },
                    { new Guid("fc02f6e5-1eec-4b1f-81e5-8aa4c95190f9"), null, new Guid("00000000-0000-0000-0000-000000000000"), "Service Boat", "Servis Botu" }
                });

            migrationBuilder.InsertData(
                table: "FacilityCategory",
                columns: new[] { "Id", "NameEn", "NameTr" },
                values: new object[,]
                {
                    { new Guid("1db7a378-5e4e-4c61-b0a2-f7dab56f6d51"), "Kitchen Equipment", "Mutfak Ekipmanları" },
                    { new Guid("a1e93a3d-6f42-4a15-a0c8-abf80693f9bc"), "Sanitary Facilities", "Sanitasyon Tesisleri" },
                    { new Guid("a3f47c0e-30a6-4c89-a4a0-5ac20551d595"), "Exterior Equipment", "Dış Ekipmanlar" },
                    { new Guid("b2f7e13b-001a-48bb-b4ef-b387c5d90a4c"), "Comfort on Board", "Yacht Konforu" },
                    { new Guid("c1c48a44-6b02-4e6a-95c5-1d262788b7f0"), "Additional Equipment", "Ekstra Ekipmanlar" },
                    { new Guid("e00c8365-914d-4874-99b5-6c43d6a96717"), "Security", "Güvenlik" }
                });

            migrationBuilder.InsertData(
                table: "Specs",
                columns: new[] { "Id", "NameEn", "NameTr" },
                values: new object[,]
                {
                    { new Guid("2a48445d-384e-4fd9-9100-60df49125e1a"), "Clean Water Tank", "Temiz Su Tankı" },
                    { new Guid("41e722c1-bfb5-48f3-b706-b99ecf754ebf"), "Generator", "Jeneratör" },
                    { new Guid("48fe5920-1dd1-4583-bf74-fbac08209ba9"), "Furling Mainsail", "Sarılabilen Ana Yelken" },
                    { new Guid("4e46cd80-163b-4718-a286-ddc378d45c13"), "Engine", "Motor" },
                    { new Guid("5d87b59a-97bc-4afb-955b-175e6556e429"), "Draft", "Taslak" },
                    { new Guid("61108cac-c37e-4f69-9ecf-ec55eda48e96"), "Wc-Shower", "Wc-Shower" },
                    { new Guid("66d2fe7f-1319-455c-b1c6-79b66b5a4420"), "Chartplotter", "Harita Plotteri" },
                    { new Guid("675bd427-8434-4f0a-96f5-9c7961ba0941"), "Classic Mainsail", "Klasik Ana Yelken" },
                    { new Guid("6e0db24f-e1eb-46eb-86b1-cde121c1cf24"), "Fuel Capacity", "Yakıt Kapasitesi" },
                    { new Guid("a0710b91-2461-41b6-a36d-827e7e68c21a"), "Built in", "Yapıldığı Yıl" },
                    { new Guid("a07cb0f9-4c39-4f57-9405-77bf8d6e1d93"), "Flag", "Bayrak" },
                    { new Guid("a7bc34ac-f43f-4e67-b59b-40ef07a31592"), "Electric Winch", "Elektrikli Winch" },
                    { new Guid("b7a326a4-7c04-4382-a667-aa0a062c4972"), "Fuel Tank", "Yakıt Tankı" },
                    { new Guid("d02087d8-7684-4b78-9d1a-7e70e092cbeb"), "Twin Cabin", "İkiz Kabin" },
                    { new Guid("da17d13c-0b26-4858-a9cb-b9582bdb74be"), "Year Of Construction", "Yapım Yılı" },
                    { new Guid("ddb0dc04-930d-453a-bf1d-2b0e674a1994"), "Water Capacity", "Su Kapasitesi" },
                    { new Guid("e0a49834-40ae-487f-ae8b-a33194cc9d1c"), "Double Cabin", "Çift Kabin" },
                    { new Guid("e51798a7-2047-4ef3-8db3-4ab87cc5d0b9"), "Model", "Model" },
                    { new Guid("e7a5e5f6-c5d5-43be-a7bc-68897d7977c1"), "Water Withdrawal", "Su Çekilmesi" },
                    { new Guid("ec25eeab-c424-477a-9b4a-a3b4f5c9e361"), "Winding Genoa", "Yelkenin Sarılması" },
                    { new Guid("f0d7957c-c779-4a6a-a9e8-07e7d097c164"), "Mainsail", "Ana Yelken" },
                    { new Guid("f713fb86-a965-4bad-8e5e-cde3714f2e0e"), "Master Cabin", "Ana Kabin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BoatFacility_FacilitiesId",
                table: "BoatFacility",
                column: "FacilitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_BoatImages_BoatId",
                table: "BoatImages",
                column: "BoatId");

            migrationBuilder.CreateIndex(
                name: "IX_Boats_Cabin",
                table: "Boats",
                column: "Cabin");

            migrationBuilder.CreateIndex(
                name: "IX_Boats_CategoryId",
                table: "Boats",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Boats_Guest",
                table: "Boats",
                column: "Guest");

            migrationBuilder.CreateIndex(
                name: "IX_BoatSpecs_SpecId",
                table: "BoatSpecs",
                column: "SpecId");

            migrationBuilder.CreateIndex(
                name: "IX_Facilities_FacilityCategoryId",
                table: "Facilities",
                column: "FacilityCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BoatFacility");

            migrationBuilder.DropTable(
                name: "BoatImages");

            migrationBuilder.DropTable(
                name: "BoatSpecs");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Facilities");

            migrationBuilder.DropTable(
                name: "Boats");

            migrationBuilder.DropTable(
                name: "Specs");

            migrationBuilder.DropTable(
                name: "FacilityCategory");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
