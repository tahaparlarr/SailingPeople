﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SailingPeople.Migrations
{
    /// <inheritdoc />
    public partial class SortOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "BoatImages",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "BoatImages");
        }
    }
}
