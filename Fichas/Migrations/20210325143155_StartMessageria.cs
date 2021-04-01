using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fichas.Migrations
{
    public partial class StartMessageria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Responsavel",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatNascto",
                table: "Acampante",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "DatNascto",
                table: "Acampante");
        }
    }
}
