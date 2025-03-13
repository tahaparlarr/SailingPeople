using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SailingPeople.Migrations
{
    /// <inheritdoc />
    public partial class Specs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Boats",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "JulyToAugustPrice",
                table: "Boats",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "JunePrice",
                table: "Boats",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MayToOctoberPrice",
                table: "Boats",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SeptemberPrice",
                table: "Boats",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Spec",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NameTr = table.Column<string>(type: "text", nullable: false),
                    NameEn = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spec", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BoatSpec",
                columns: table => new
                {
                    BoatId = table.Column<Guid>(type: "uuid", nullable: false),
                    SpecId = table.Column<Guid>(type: "uuid", nullable: false),
                    ValueTr = table.Column<string>(type: "text", nullable: false),
                    ValueEn = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoatSpec", x => new { x.BoatId, x.SpecId });
                    table.ForeignKey(
                        name: "FK_BoatSpec_Boats_BoatId",
                        column: x => x.BoatId,
                        principalTable: "Boats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoatSpec_Spec_SpecId",
                        column: x => x.SpecId,
                        principalTable: "Spec",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Spec",
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
                name: "IX_Boats_Cabin",
                table: "Boats",
                column: "Cabin");

            migrationBuilder.CreateIndex(
                name: "IX_Boats_Guest",
                table: "Boats",
                column: "Guest");

            migrationBuilder.CreateIndex(
                name: "IX_BoatSpec_SpecId",
                table: "BoatSpec",
                column: "SpecId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoatSpec");

            migrationBuilder.DropTable(
                name: "Spec");

            migrationBuilder.DropIndex(
                name: "IX_Boats_Cabin",
                table: "Boats");

            migrationBuilder.DropIndex(
                name: "IX_Boats_Guest",
                table: "Boats");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Boats");

            migrationBuilder.DropColumn(
                name: "JulyToAugustPrice",
                table: "Boats");

            migrationBuilder.DropColumn(
                name: "JunePrice",
                table: "Boats");

            migrationBuilder.DropColumn(
                name: "MayToOctoberPrice",
                table: "Boats");

            migrationBuilder.DropColumn(
                name: "SeptemberPrice",
                table: "Boats");
        }
    }
}
