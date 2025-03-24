using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SailingPeople.Migrations
{
    /// <inheritdoc />
    public partial class NewSpcFacy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("16da6aca-5f9e-43c8-b2d7-40cb02ed4bdf"),
                column: "NameEn",
                value: "Bimini Top");

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("2f41793a-1d95-4006-8eeb-107ea418bc9c"),
                column: "NameEn",
                value: "Depth Sounder");

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("78a8f2d1-9e2f-45e7-8dc2-8e1d640869c2"),
                column: "NameEn",
                value: "Satellite Connection");

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("91cb398e-aae9-4d71-ad39-138aca252b25"),
                columns: new[] { "NameEn", "NameTr" },
                values: new object[] { "Internet Connection", "İnternet Bağlantısı" });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("96b23f3c-bc3e-4260-8a21-8392a44e482f"),
                column: "NameTr",
                value: "Baş Pervane");

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("ad91b440-9e12-4d6c-926b-7887397d1a79"),
                columns: new[] { "NameEn", "NameTr" },
                values: new object[] { "Navtex (Satellite Weather Report)", "Navtex (Uydu Hava Raporu)" });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("d2337f7f-581c-4df3-966f-d40ef528efcc"),
                column: "NameEn",
                value: "TV / DVD");

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("db35e9f6-419d-4c9e-a200-2c9902f9d148"),
                column: "NameEn",
                value: "Refrigerator");

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("e6d0c77b-714b-455f-8498-2433dbfae51a"),
                column: "NameEn",
                value: "Swim Ladder");

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("e7f5594f-41eb-444f-80ea-2cd05cdffbea"),
                column: "NameEn",
                value: "Tender");

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("f00c470f-0595-4c35-af61-964e15ca4335"),
                column: "NameEn",
                value: "Hot Water");

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("fc02f6e5-1eec-4b1f-81e5-8aa4c95190f9"),
                column: "NameEn",
                value: "Tender");

            migrationBuilder.UpdateData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: new Guid("2a48445d-384e-4fd9-9100-60df49125e1a"),
                column: "NameEn",
                value: "Fresh Water Tank");

            migrationBuilder.UpdateData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: new Guid("61108cac-c37e-4f69-9ecf-ec55eda48e96"),
                column: "NameEn",
                value: "WC-Shower");

            migrationBuilder.UpdateData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: new Guid("a0710b91-2461-41b6-a36d-827e7e68c21a"),
                column: "NameEn",
                value: "Year Built");

            migrationBuilder.UpdateData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: new Guid("da17d13c-0b26-4858-a9cb-b9582bdb74be"),
                column: "NameEn",
                value: "Year of Construction");

            migrationBuilder.UpdateData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: new Guid("e7a5e5f6-c5d5-43be-a7bc-68897d7977c1"),
                column: "NameEn",
                value: "Draft");

            migrationBuilder.UpdateData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: new Guid("ec25eeab-c424-477a-9b4a-a3b4f5c9e361"),
                column: "NameEn",
                value: "Furling Genoa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("16da6aca-5f9e-43c8-b2d7-40cb02ed4bdf"),
                column: "NameEn",
                value: "Biminitop");

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("2f41793a-1d95-4006-8eeb-107ea418bc9c"),
                column: "NameEn",
                value: "Depth Sounding");

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("78a8f2d1-9e2f-45e7-8dc2-8e1d640869c2"),
                column: "NameEn",
                value: "Satellite Link");

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("91cb398e-aae9-4d71-ad39-138aca252b25"),
                columns: new[] { "NameEn", "NameTr" },
                values: new object[] { "Internet connection", "Internet Bağlantısı" });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("96b23f3c-bc3e-4260-8a21-8392a44e482f"),
                column: "NameTr",
                value: "Pervane İleri Yön");

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("ad91b440-9e12-4d6c-926b-7887397d1a79"),
                columns: new[] { "NameEn", "NameTr" },
                values: new object[] { "Navtek (Satellite Weather Report)", "Navtek (Uydu Hava Raporu)" });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("d2337f7f-581c-4df3-966f-d40ef528efcc"),
                column: "NameEn",
                value: "TV/DVD");

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("db35e9f6-419d-4c9e-a200-2c9902f9d148"),
                column: "NameEn",
                value: "Freezer");

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("e6d0c77b-714b-455f-8498-2433dbfae51a"),
                column: "NameEn",
                value: "Swimming Ladder");

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("e7f5594f-41eb-444f-80ea-2cd05cdffbea"),
                column: "NameEn",
                value: "Service Boat");

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("f00c470f-0595-4c35-af61-964e15ca4335"),
                column: "NameEn",
                value: "Hot water");

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("fc02f6e5-1eec-4b1f-81e5-8aa4c95190f9"),
                column: "NameEn",
                value: "Service Boat");

            migrationBuilder.UpdateData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: new Guid("2a48445d-384e-4fd9-9100-60df49125e1a"),
                column: "NameEn",
                value: "Clean Water Tank");

            migrationBuilder.UpdateData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: new Guid("61108cac-c37e-4f69-9ecf-ec55eda48e96"),
                column: "NameEn",
                value: "Wc-Shower");

            migrationBuilder.UpdateData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: new Guid("a0710b91-2461-41b6-a36d-827e7e68c21a"),
                column: "NameEn",
                value: "Built in");

            migrationBuilder.UpdateData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: new Guid("da17d13c-0b26-4858-a9cb-b9582bdb74be"),
                column: "NameEn",
                value: "Year Of Construction");

            migrationBuilder.UpdateData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: new Guid("e7a5e5f6-c5d5-43be-a7bc-68897d7977c1"),
                column: "NameEn",
                value: "Water Withdrawal");

            migrationBuilder.UpdateData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: new Guid("ec25eeab-c424-477a-9b4a-a3b4f5c9e361"),
                column: "NameEn",
                value: "Winding Genoa");
        }
    }
}
