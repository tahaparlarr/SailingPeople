using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SailingPeople.Migrations
{
    /// <inheritdoc />
    public partial class NewFacilityCat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facilities_FacilityCategory_FacilityCategoryId",
                table: "Facilities");

            migrationBuilder.DropColumn(
                name: "FacilityId",
                table: "Facilities");

            migrationBuilder.AlterColumn<Guid>(
                name: "FacilityCategoryId",
                table: "Facilities",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("150d1179-8548-47c4-aff4-e4ca001b1ed1"),
                column: "FacilityCategoryId",
                value: new Guid("b2f7e13b-001a-48bb-b4ef-b387c5d90a4c"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("16da6aca-5f9e-43c8-b2d7-40cb02ed4bdf"),
                column: "FacilityCategoryId",
                value: new Guid("a3f47c0e-30a6-4c89-a4a0-5ac20551d595"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("2681befa-cacb-4372-b385-b701d8d8705f"),
                column: "FacilityCategoryId",
                value: new Guid("a3f47c0e-30a6-4c89-a4a0-5ac20551d595"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("2f41793a-1d95-4006-8eeb-107ea418bc9c"),
                column: "FacilityCategoryId",
                value: new Guid("c1c48a44-6b02-4e6a-95c5-1d262788b7f0"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("339d8f62-0712-4d39-9a94-c0dba1aeeeed"),
                column: "FacilityCategoryId",
                value: new Guid("a3f47c0e-30a6-4c89-a4a0-5ac20551d595"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("3a325ebd-361d-4859-8125-9656796a20da"),
                column: "FacilityCategoryId",
                value: new Guid("a3f47c0e-30a6-4c89-a4a0-5ac20551d595"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("3af46fcc-d59b-407f-b72f-669730089f9c"),
                column: "FacilityCategoryId",
                value: new Guid("a1e93a3d-6f42-4a15-a0c8-abf80693f9bc"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("57c2b597-bbb6-46f9-babf-5283dba0a65a"),
                column: "FacilityCategoryId",
                value: new Guid("a3f47c0e-30a6-4c89-a4a0-5ac20551d595"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("5f8efc71-7086-451a-8014-d8064bb07a76"),
                column: "FacilityCategoryId",
                value: new Guid("a3f47c0e-30a6-4c89-a4a0-5ac20551d595"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("75e90b41-8a80-4fce-8bd9-4840b1169f91"),
                column: "FacilityCategoryId",
                value: new Guid("a1e93a3d-6f42-4a15-a0c8-abf80693f9bc"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("78a8f2d1-9e2f-45e7-8dc2-8e1d640869c2"),
                column: "FacilityCategoryId",
                value: new Guid("a3f47c0e-30a6-4c89-a4a0-5ac20551d595"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("79bbb137-57b4-4fc9-8e2e-db874f05b9c8"),
                column: "FacilityCategoryId",
                value: new Guid("b2f7e13b-001a-48bb-b4ef-b387c5d90a4c"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("88f8f14f-8a9a-45a4-954d-0ff7f1d8265f"),
                column: "FacilityCategoryId",
                value: new Guid("c1c48a44-6b02-4e6a-95c5-1d262788b7f0"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("91cb398e-aae9-4d71-ad39-138aca252b25"),
                column: "FacilityCategoryId",
                value: new Guid("b2f7e13b-001a-48bb-b4ef-b387c5d90a4c"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("96b23f3c-bc3e-4260-8a21-8392a44e482f"),
                column: "FacilityCategoryId",
                value: new Guid("e00c8365-914d-4874-99b5-6c43d6a96717"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("987ee924-82a0-44e3-b207-4daed6e59f72"),
                column: "FacilityCategoryId",
                value: new Guid("b2f7e13b-001a-48bb-b4ef-b387c5d90a4c"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("99d9f57f-abf0-4d9f-85b5-db8a045c2b9c"),
                column: "FacilityCategoryId",
                value: new Guid("1db7a378-5e4e-4c61-b0a2-f7dab56f6d51"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("ad91b440-9e12-4d6c-926b-7887397d1a79"),
                column: "FacilityCategoryId",
                value: new Guid("a3f47c0e-30a6-4c89-a4a0-5ac20551d595"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("b6e2aa72-3ce9-4bed-96cb-b5a6ad0f1385"),
                column: "FacilityCategoryId",
                value: new Guid("c1c48a44-6b02-4e6a-95c5-1d262788b7f0"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("bc41edb3-0ae7-4205-8e4e-cce9a5a34b0e"),
                column: "FacilityCategoryId",
                value: new Guid("a1e93a3d-6f42-4a15-a0c8-abf80693f9bc"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("c8f70da8-6e5a-4a96-a8ed-e50b282636de"),
                column: "FacilityCategoryId",
                value: new Guid("a1e93a3d-6f42-4a15-a0c8-abf80693f9bc"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("d16ac7ab-2c8e-4ae2-8a0f-f0f5a9397123"),
                column: "FacilityCategoryId",
                value: new Guid("c1c48a44-6b02-4e6a-95c5-1d262788b7f0"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("d2337f7f-581c-4df3-966f-d40ef528efcc"),
                column: "FacilityCategoryId",
                value: new Guid("a3f47c0e-30a6-4c89-a4a0-5ac20551d595"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("d59d28e3-319d-4682-8e59-67667d947a83"),
                column: "FacilityCategoryId",
                value: new Guid("e00c8365-914d-4874-99b5-6c43d6a96717"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("d97179ef-f17c-4cca-a9d2-7afb13c715f3"),
                column: "FacilityCategoryId",
                value: new Guid("a3f47c0e-30a6-4c89-a4a0-5ac20551d595"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("db35e9f6-419d-4c9e-a200-2c9902f9d148"),
                column: "FacilityCategoryId",
                value: new Guid("1db7a378-5e4e-4c61-b0a2-f7dab56f6d51"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("dcb774d6-77ba-4090-85fa-bce964e02bbc"),
                column: "FacilityCategoryId",
                value: new Guid("b2f7e13b-001a-48bb-b4ef-b387c5d90a4c"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("e6d0c77b-714b-455f-8498-2433dbfae51a"),
                column: "FacilityCategoryId",
                value: new Guid("b2f7e13b-001a-48bb-b4ef-b387c5d90a4c"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("e7f5594f-41eb-444f-80ea-2cd05cdffbea"),
                column: "FacilityCategoryId",
                value: new Guid("a3f47c0e-30a6-4c89-a4a0-5ac20551d595"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("ed3153d1-bd7d-4c6d-8e77-31677244351c"),
                column: "FacilityCategoryId",
                value: new Guid("a3f47c0e-30a6-4c89-a4a0-5ac20551d595"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("f00c470f-0595-4c35-af61-964e15ca4335"),
                column: "FacilityCategoryId",
                value: new Guid("a1e93a3d-6f42-4a15-a0c8-abf80693f9bc"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("f46b0b14-9719-46ca-b460-660e6a22f2dd"),
                column: "FacilityCategoryId",
                value: new Guid("b2f7e13b-001a-48bb-b4ef-b387c5d90a4c"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("fc02f6e5-1eec-4b1f-81e5-8aa4c95190f9"),
                column: "FacilityCategoryId",
                value: new Guid("c1c48a44-6b02-4e6a-95c5-1d262788b7f0"));

            migrationBuilder.AddForeignKey(
                name: "FK_Facilities_FacilityCategory_FacilityCategoryId",
                table: "Facilities",
                column: "FacilityCategoryId",
                principalTable: "FacilityCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facilities_FacilityCategory_FacilityCategoryId",
                table: "Facilities");

            migrationBuilder.AlterColumn<Guid>(
                name: "FacilityCategoryId",
                table: "Facilities",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<Guid>(
                name: "FacilityId",
                table: "Facilities",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("150d1179-8548-47c4-aff4-e4ca001b1ed1"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("16da6aca-5f9e-43c8-b2d7-40cb02ed4bdf"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("2681befa-cacb-4372-b385-b701d8d8705f"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("2f41793a-1d95-4006-8eeb-107ea418bc9c"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("339d8f62-0712-4d39-9a94-c0dba1aeeeed"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("3a325ebd-361d-4859-8125-9656796a20da"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("3af46fcc-d59b-407f-b72f-669730089f9c"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("57c2b597-bbb6-46f9-babf-5283dba0a65a"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("5f8efc71-7086-451a-8014-d8064bb07a76"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("75e90b41-8a80-4fce-8bd9-4840b1169f91"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("78a8f2d1-9e2f-45e7-8dc2-8e1d640869c2"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("79bbb137-57b4-4fc9-8e2e-db874f05b9c8"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("88f8f14f-8a9a-45a4-954d-0ff7f1d8265f"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("91cb398e-aae9-4d71-ad39-138aca252b25"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("96b23f3c-bc3e-4260-8a21-8392a44e482f"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("987ee924-82a0-44e3-b207-4daed6e59f72"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("99d9f57f-abf0-4d9f-85b5-db8a045c2b9c"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("ad91b440-9e12-4d6c-926b-7887397d1a79"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("b6e2aa72-3ce9-4bed-96cb-b5a6ad0f1385"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("bc41edb3-0ae7-4205-8e4e-cce9a5a34b0e"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("c8f70da8-6e5a-4a96-a8ed-e50b282636de"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("d16ac7ab-2c8e-4ae2-8a0f-f0f5a9397123"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("d2337f7f-581c-4df3-966f-d40ef528efcc"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("d59d28e3-319d-4682-8e59-67667d947a83"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("d97179ef-f17c-4cca-a9d2-7afb13c715f3"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("db35e9f6-419d-4c9e-a200-2c9902f9d148"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("dcb774d6-77ba-4090-85fa-bce964e02bbc"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("e6d0c77b-714b-455f-8498-2433dbfae51a"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("e7f5594f-41eb-444f-80ea-2cd05cdffbea"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("ed3153d1-bd7d-4c6d-8e77-31677244351c"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("f00c470f-0595-4c35-af61-964e15ca4335"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("f46b0b14-9719-46ca-b460-660e6a22f2dd"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: new Guid("fc02f6e5-1eec-4b1f-81e5-8aa4c95190f9"),
                columns: new[] { "FacilityCategoryId", "FacilityId" },
                values: new object[] { null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.AddForeignKey(
                name: "FK_Facilities_FacilityCategory_FacilityCategoryId",
                table: "Facilities",
                column: "FacilityCategoryId",
                principalTable: "FacilityCategory",
                principalColumn: "Id");
        }
    }
}
