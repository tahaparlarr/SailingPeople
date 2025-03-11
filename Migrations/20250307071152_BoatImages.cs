using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SailingPeople.Migrations
{
    /// <inheritdoc />
    public partial class BoatImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: new Guid("48e18fa6-d0ce-42c7-8c82-821fa712b19c"));

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: new Guid("a2eb082b-0e8e-4058-87f6-4d3ce572469c"));

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: new Guid("a796c61a-34ad-4227-a690-d3def244095e"));

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: new Guid("c7b18dd1-762d-4881-bd64-e2917ce5e8e2"));

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: new Guid("cfa4f257-21ac-42a5-bbd3-64c1dcff2f97"));

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: new Guid("ee863d05-0218-47d7-a899-88e17b5b1ebc"));

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Boats",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

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

            migrationBuilder.CreateIndex(
                name: "IX_BoatImages_BoatId",
                table: "BoatImages",
                column: "BoatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoatImages");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Boats",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Boats",
                columns: new[] { "Id", "Cabin", "CategoryId", "Guest", "Image", "Length", "Name", "RentType", "Width" },
                values: new object[,]
                {
                    { new Guid("48e18fa6-d0ce-42c7-8c82-821fa712b19c"), 3, new Guid("a2092ee2-5218-4846-a716-024b57c1989e"), 8, "", 20f, "Boat 3", 0, 30f },
                    { new Guid("a2eb082b-0e8e-4058-87f6-4d3ce572469c"), 3, new Guid("9ab03277-4a7f-401e-9677-02d6853227f0"), 8, "", 20f, "Boat 2", 0, 30f },
                    { new Guid("a796c61a-34ad-4227-a690-d3def244095e"), 3, new Guid("4cdf4cd0-dda7-41ed-bf55-76a2c5dbf0a0"), 8, "", 20f, "Boat 1", 0, 30f },
                    { new Guid("c7b18dd1-762d-4881-bd64-e2917ce5e8e2"), 3, new Guid("9ab03277-4a7f-401e-9677-02d6853227f0"), 8, "", 20f, "Boat 3", 0, 30f },
                    { new Guid("cfa4f257-21ac-42a5-bbd3-64c1dcff2f97"), 3, new Guid("9a242089-51bc-4f73-b2d5-033c4e20003f"), 8, "", 20f, "Boat 3", 0, 30f },
                    { new Guid("ee863d05-0218-47d7-a899-88e17b5b1ebc"), 3, new Guid("9a242089-51bc-4f73-b2d5-033c4e20003f"), 8, "", 20f, "Boat 3", 0, 30f }
                });
        }
    }
}
