using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Migrations
{
    /// <inheritdoc />
    public partial class nnn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Pracs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Pracs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RectangleLabels",
                table: "Pracs",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Pracs");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Pracs");

            migrationBuilder.DropColumn(
                name: "RectangleLabels",
                table: "Pracs");
        }
    }
}
