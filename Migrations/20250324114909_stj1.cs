using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SailingPeople.Migrations
{
    /// <inheritdoc />
    public partial class stj1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("d16ac7ab-2c8e-4ae2-8a0f-f0f5a9397123"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("fc02f6e5-1eec-4b1f-81e5-8aa4c95190f9"));

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: new Guid("5d87b59a-97bc-4afb-955b-175e6556e429"));

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: new Guid("a0710b91-2461-41b6-a36d-827e7e68c21a"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "Id", "FacilityCategoryId", "NameEn", "NameTr" },
                values: new object[,]
                {
                    { new Guid("d16ac7ab-2c8e-4ae2-8a0f-f0f5a9397123"), new Guid("c1c48a44-6b02-4e6a-95c5-1d262788b7f0"), "Canoe", "Kano" },
                    { new Guid("fc02f6e5-1eec-4b1f-81e5-8aa4c95190f9"), new Guid("c1c48a44-6b02-4e6a-95c5-1d262788b7f0"), "Tender", "Servis Botu" }
                });

            migrationBuilder.InsertData(
                table: "Specs",
                columns: new[] { "Id", "NameEn", "NameTr" },
                values: new object[,]
                {
                    { new Guid("5d87b59a-97bc-4afb-955b-175e6556e429"), "Draft", "Taslak" },
                    { new Guid("a0710b91-2461-41b6-a36d-827e7e68c21a"), "Year Built", "Yapıldığı Yıl" }
                });
        }
    }
}
