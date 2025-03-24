using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SailingPeople.Migrations
{
    /// <inheritdoc />
    public partial class UpdtSpec1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Specs",
                columns: new[] { "Id", "NameEn", "NameTr" },
                values: new object[] { new Guid("06031532-9bb8-4649-9a83-737da095f1a3"), "Service Bot", "Servis Botu" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: new Guid("06031532-9bb8-4649-9a83-737da095f1a3"));
        }
    }
}
