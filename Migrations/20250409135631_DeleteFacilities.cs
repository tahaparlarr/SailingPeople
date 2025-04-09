using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SailingPeople.Migrations
{
    /// <inheritdoc />
    public partial class DeleteFacilities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("de11f0f5-4e9b-4e5f-a7fb-15b370b0f929"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "Id", "FacilityCategoryId", "NameEn", "NameTr" },
                values: new object[] { new Guid("de11f0f5-4e9b-4e5f-a7fb-15b370b0f929"), new Guid("1db7a378-5e4e-4c61-b0a2-f7dab56f6d51"), "Refrigerator", "Buzdolabı" });
        }
    }
}
