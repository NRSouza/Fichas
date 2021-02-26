using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fichas.Migrations
{
    public partial class Covd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Necessidade_Especial",
                table: "Ficha",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Alergia_Medicamento",
                table: "Ficha",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<bool>(
                name: "Alopatia",
                table: "Ficha",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Covid",
                table: "Ficha",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Dat_Covid",
                table: "Ficha",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Homeopatia",
                table: "Ficha",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alopatia",
                table: "Ficha");

            migrationBuilder.DropColumn(
                name: "Covid",
                table: "Ficha");

            migrationBuilder.DropColumn(
                name: "Dat_Covid",
                table: "Ficha");

            migrationBuilder.DropColumn(
                name: "Homeopatia",
                table: "Ficha");

            migrationBuilder.AlterColumn<bool>(
                name: "Necessidade_Especial",
                table: "Ficha",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<bool>(
                name: "Alergia_Medicamento",
                table: "Ficha",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
