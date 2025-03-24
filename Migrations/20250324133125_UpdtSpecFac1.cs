using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SailingPeople.Migrations
{
    /// <inheritdoc />
    public partial class UpdtSpecFac1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: new Guid("06031532-9bb8-4649-9a83-737da095f1a3"));

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: new Guid("61108cac-c37e-4f69-9ecf-ec55eda48e96"));

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: new Guid("675bd427-8434-4f0a-96f5-9c7961ba0941"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("ad91b440-9e12-4d6c-926b-7887397d1a79"),
                column: "FacilityCategoryId",
                value: new Guid("e00c8365-914d-4874-99b5-6c43d6a96717"));

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "Id", "FacilityCategoryId", "NameEn", "NameTr" },
                values: new object[,]
                {
                    { new Guid("144e94aa-6d38-45d1-bb8e-678019de37fd"), new Guid("e00c8365-914d-4874-99b5-6c43d6a96717"), "Radar", "Radar" },
                    { new Guid("3e5e14c8-a9fa-4b54-a4ee-ec82189b10af"), new Guid("1db7a378-5e4e-4c61-b0a2-f7dab56f6d51"), "Ice Machine", "Buz Makinesi" },
                    { new Guid("d3cd6394-3222-46df-a677-c9302e9499bf"), new Guid("e00c8365-914d-4874-99b5-6c43d6a96717"), "VHF", "VHF" },
                    { new Guid("d5bd72e7-a67d-4731-9694-87b0e86de2a2"), new Guid("a3f47c0e-30a6-4c89-a4a0-5ac20551d595"), "Service Boat", "Servis Botu" },
                    { new Guid("dc88f861-098d-4152-b101-a8157c803daf"), new Guid("a3f47c0e-30a6-4c89-a4a0-5ac20551d595"), "Klasik Ana Yelken", "Classic Mainsail" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("144e94aa-6d38-45d1-bb8e-678019de37fd"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("3e5e14c8-a9fa-4b54-a4ee-ec82189b10af"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("d3cd6394-3222-46df-a677-c9302e9499bf"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("d5bd72e7-a67d-4731-9694-87b0e86de2a2"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("dc88f861-098d-4152-b101-a8157c803daf"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("ad91b440-9e12-4d6c-926b-7887397d1a79"),
                column: "FacilityCategoryId",
                value: new Guid("a3f47c0e-30a6-4c89-a4a0-5ac20551d595"));

            migrationBuilder.InsertData(
                table: "Specs",
                columns: new[] { "Id", "NameEn", "NameTr" },
                values: new object[,]
                {
                    { new Guid("06031532-9bb8-4649-9a83-737da095f1a3"), "Service Bot", "Servis Botu" },
                    { new Guid("61108cac-c37e-4f69-9ecf-ec55eda48e96"), "WC-Shower", "Wc-Shower" },
                    { new Guid("675bd427-8434-4f0a-96f5-9c7961ba0941"), "Classic Mainsail", "Klasik Ana Yelken" }
                });
        }
    }
}
