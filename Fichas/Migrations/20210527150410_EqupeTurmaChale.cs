using Microsoft.EntityFrameworkCore.Migrations;

namespace Fichas.Migrations
{
    public partial class EqupeTurmaChale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Equipe",
                table: "Acampante",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Chale",
                table: "Acampante",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TurmaNR",
                table: "Acampante",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Chale",
                table: "Acampante");

            migrationBuilder.DropColumn(
                name: "TurmaNR",
                table: "Acampante");

            migrationBuilder.AlterColumn<int>(
                name: "Equipe",
                table: "Acampante",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
