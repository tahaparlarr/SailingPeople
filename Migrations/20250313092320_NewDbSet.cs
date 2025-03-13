using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SailingPeople.Migrations
{
    /// <inheritdoc />
    public partial class NewDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoatSpec_Boats_BoatId",
                table: "BoatSpec");

            migrationBuilder.DropForeignKey(
                name: "FK_BoatSpec_Spec_SpecId",
                table: "BoatSpec");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Spec",
                table: "Spec");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BoatSpec",
                table: "BoatSpec");

            migrationBuilder.RenameTable(
                name: "Spec",
                newName: "Specs");

            migrationBuilder.RenameTable(
                name: "BoatSpec",
                newName: "BoatSpecs");

            migrationBuilder.RenameIndex(
                name: "IX_BoatSpec_SpecId",
                table: "BoatSpecs",
                newName: "IX_BoatSpecs_SpecId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Specs",
                table: "Specs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BoatSpecs",
                table: "BoatSpecs",
                columns: new[] { "BoatId", "SpecId" });

            migrationBuilder.AddForeignKey(
                name: "FK_BoatSpecs_Boats_BoatId",
                table: "BoatSpecs",
                column: "BoatId",
                principalTable: "Boats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BoatSpecs_Specs_SpecId",
                table: "BoatSpecs",
                column: "SpecId",
                principalTable: "Specs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoatSpecs_Boats_BoatId",
                table: "BoatSpecs");

            migrationBuilder.DropForeignKey(
                name: "FK_BoatSpecs_Specs_SpecId",
                table: "BoatSpecs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Specs",
                table: "Specs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BoatSpecs",
                table: "BoatSpecs");

            migrationBuilder.RenameTable(
                name: "Specs",
                newName: "Spec");

            migrationBuilder.RenameTable(
                name: "BoatSpecs",
                newName: "BoatSpec");

            migrationBuilder.RenameIndex(
                name: "IX_BoatSpecs_SpecId",
                table: "BoatSpec",
                newName: "IX_BoatSpec_SpecId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Spec",
                table: "Spec",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BoatSpec",
                table: "BoatSpec",
                columns: new[] { "BoatId", "SpecId" });

            migrationBuilder.AddForeignKey(
                name: "FK_BoatSpec_Boats_BoatId",
                table: "BoatSpec",
                column: "BoatId",
                principalTable: "Boats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BoatSpec_Spec_SpecId",
                table: "BoatSpec",
                column: "SpecId",
                principalTable: "Spec",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
