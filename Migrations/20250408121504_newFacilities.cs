using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SailingPeople.Migrations
{
    /// <inheritdoc />
    public partial class newFacilities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "Id", "FacilityCategoryId", "NameEn", "NameTr" },
                values: new object[,]
                {
                    { new Guid("1b2a1d64-87d3-49dc-927d-0c44e8d42e9c"), new Guid("1db7a378-5e4e-4c61-b0a2-f7dab56f6d51"), "Oven", "Fırın" },
                    { new Guid("26a6d23e-8d6b-4c50-9d8f-08bb9a388ff8"), new Guid("a3f47c0e-30a6-4c89-a4a0-5ac20551d595"), "Sunbathing Beds", "Güneşlenme Yatakları" },
                    { new Guid("3c61755b-6a85-4a35-bd67-2e6a3a161e97"), new Guid("1db7a378-5e4e-4c61-b0a2-f7dab56f6d51"), "Heater", "Isıtıcı" },
                    { new Guid("4a489577-9462-46b2-925c-ce21153c1730"), new Guid("c1c48a44-6b02-4e6a-95c5-1d262788b7f0"), "Inverter", "Inverter" },
                    { new Guid("4e41e85a-7fb3-45e7-832d-51a63f06034e"), new Guid("1db7a378-5e4e-4c61-b0a2-f7dab56f6d51"), "Kitchen Utensils", "Mutfak Malzemeleri" },
                    { new Guid("4efa6ff3-7984-4e59-b23f-7f3f3873d687"), new Guid("b2f7e13b-001a-48bb-b4ef-b387c5d90a4c"), "Crew Cabin", "Crew Kabin" },
                    { new Guid("548506fe-b619-4f76-b0ad-2f33d5102d85"), new Guid("c1c48a44-6b02-4e6a-95c5-1d262788b7f0"), "Generator", "Jeneratör" },
                    { new Guid("6d962a0b-9231-49e5-82b7-03516e3b48d7"), new Guid("a1e93a3d-6f42-4a15-a0c8-abf80693f9bc"), "Waste Tank", "Atık Tankı" },
                    { new Guid("6f91253d-9f4d-475a-8f4a-8f29c27db56a"), new Guid("1db7a378-5e4e-4c61-b0a2-f7dab56f6d51"), "Stove", "Ocak" },
                    { new Guid("8d2a1e78-1a79-4f39-92c5-b4f26519bcb1"), new Guid("b2f7e13b-001a-48bb-b4ef-b387c5d90a4c"), "Towel", "Havlu" },
                    { new Guid("9e671baf-3d9e-4c2d-9196-8b694e22787a"), new Guid("1db7a378-5e4e-4c61-b0a2-f7dab56f6d51"), "Grill", "Mangal" },
                    { new Guid("a0338a12-ada7-4b99-bec5-8b1a0d9fb9a9"), new Guid("1db7a378-5e4e-4c61-b0a2-f7dab56f6d51"), "Microwave Oven", "Mikrodalga Fırın" },
                    { new Guid("a1b45a2b-9c31-4d53-9009-7416da5e1b0d"), new Guid("c1c48a44-6b02-4e6a-95c5-1d262788b7f0"), "Solar Panels", "Güneş Panelleri" },
                    { new Guid("a67f8e7f-a53a-43e3-90b9-d88dde8c9d28"), new Guid("a3f47c0e-30a6-4c89-a4a0-5ac20551d595"), "Dinghy", "Dingi" },
                    { new Guid("b7c347b2-0f5d-48dc-a432-34e0d56b0972"), new Guid("1db7a378-5e4e-4c61-b0a2-f7dab56f6d51"), "Freezer", "Dondurucu" },
                    { new Guid("c3f93f88-5e5d-4635-9149-17ee18a0140c"), new Guid("c1c48a44-6b02-4e6a-95c5-1d262788b7f0"), "Salon GPS Plotter", "Salon GPS Plotter" },
                    { new Guid("c983405d-9a7e-49fb-b5b3-4b06b04f1a44"), new Guid("c1c48a44-6b02-4e6a-95c5-1d262788b7f0"), "Sound System", "Ses Sistemi" },
                    { new Guid("dcc1a4ec-3208-48f9-9f67-917fd0802c09"), new Guid("c1c48a44-6b02-4e6a-95c5-1d262788b7f0"), "Electric Winches", "Electric Winches" },
                    { new Guid("de11f0f5-4e9b-4e5f-a7fb-15b370b0f929"), new Guid("1db7a378-5e4e-4c61-b0a2-f7dab56f6d51"), "Refrigerator", "Buzdolabı" },
                    { new Guid("f2e6f7f3-a056-4552-8fc7-72aa11d23e3e"), new Guid("a1e93a3d-6f42-4a15-a0c8-abf80693f9bc"), "Sink", "Lavabo" },
                    { new Guid("f5b1467c-bd30-4d28-a9e0-b5b4e42db3db"), new Guid("c1c48a44-6b02-4e6a-95c5-1d262788b7f0"), "Cockpit Speakers", "Kokpit Hoparlörleri" },
                    { new Guid("f97f6d36-8100-4721-917f-0f5716fdf8a9"), new Guid("b2f7e13b-001a-48bb-b4ef-b387c5d90a4c"), "Pillows and Blankets", "Yastıklar ve Battaniyeler" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("1b2a1d64-87d3-49dc-927d-0c44e8d42e9c"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("26a6d23e-8d6b-4c50-9d8f-08bb9a388ff8"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("3c61755b-6a85-4a35-bd67-2e6a3a161e97"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("4a489577-9462-46b2-925c-ce21153c1730"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("4e41e85a-7fb3-45e7-832d-51a63f06034e"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("4efa6ff3-7984-4e59-b23f-7f3f3873d687"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("548506fe-b619-4f76-b0ad-2f33d5102d85"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("6d962a0b-9231-49e5-82b7-03516e3b48d7"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("6f91253d-9f4d-475a-8f4a-8f29c27db56a"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("8d2a1e78-1a79-4f39-92c5-b4f26519bcb1"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("9e671baf-3d9e-4c2d-9196-8b694e22787a"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("a0338a12-ada7-4b99-bec5-8b1a0d9fb9a9"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("a1b45a2b-9c31-4d53-9009-7416da5e1b0d"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("a67f8e7f-a53a-43e3-90b9-d88dde8c9d28"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("b7c347b2-0f5d-48dc-a432-34e0d56b0972"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("c3f93f88-5e5d-4635-9149-17ee18a0140c"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("c983405d-9a7e-49fb-b5b3-4b06b04f1a44"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("dcc1a4ec-3208-48f9-9f67-917fd0802c09"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("de11f0f5-4e9b-4e5f-a7fb-15b370b0f929"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("f2e6f7f3-a056-4552-8fc7-72aa11d23e3e"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("f5b1467c-bd30-4d28-a9e0-b5b4e42db3db"));

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("f97f6d36-8100-4721-917f-0f5716fdf8a9"));
        }
    }
}
