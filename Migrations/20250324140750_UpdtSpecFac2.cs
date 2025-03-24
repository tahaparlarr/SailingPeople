using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SailingPeople.Migrations
{
    /// <inheritdoc />
    public partial class UpdtSpecFac2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("dc88f861-098d-4152-b101-a8157c803daf"),
                columns: new[] { "NameEn", "NameTr" },
                values: new object[] { "Classic Mainsail", "Klasik Ana Yelken" });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "Id", "FacilityCategoryId", "NameEn", "NameTr" },
                values: new object[,]
                {
                    { new Guid("2f700ce8-3625-4c97-8ca5-1a6ff658fb64"), new Guid("1db7a378-5e4e-4c61-b0a2-f7dab56f6d51"), "Coffee Machine", "Kahve Makinesi" },
                    { new Guid("3ed945b9-de82-461d-9349-6638dd2a75b4"), new Guid("c1c48a44-6b02-4e6a-95c5-1d262788b7f0"), "Fire Extinguisher", "Yangın Söndürücü" },
                    { new Guid("51d8be6d-0990-41b7-9754-1b64860fde74"), new Guid("e00c8365-914d-4874-99b5-6c43d6a96717"), "Navigation", "Navigasyon" },
                    { new Guid("a47e35dc-69ac-46bf-bff5-43e9d26be416"), new Guid("c1c48a44-6b02-4e6a-95c5-1d262788b7f0"), "Repair Kits", "Tamir Kitleri" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("2f700ce8-3625-4c97-8ca5-1a6ff658fb64"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("3ed945b9-de82-461d-9349-6638dd2a75b4"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("51d8be6d-0990-41b7-9754-1b64860fde74"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("a47e35dc-69ac-46bf-bff5-43e9d26be416"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("dc88f861-098d-4152-b101-a8157c803daf"),
                columns: new[] { "NameEn", "NameTr" },
                values: new object[] { "Klasik Ana Yelken", "Classic Mainsail" });
        }
    }
}
