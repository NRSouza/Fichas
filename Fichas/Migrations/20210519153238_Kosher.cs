using Microsoft.EntityFrameworkCore.Migrations;

namespace Fichas.Migrations
{
    public partial class Kosher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "FreeKosher",
                table: "Ficha",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "WeDoKosher",
                table: "Ficha",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FreeKosher",
                table: "Ficha");

            migrationBuilder.DropColumn(
                name: "WeDoKosher",
                table: "Ficha");
        }
    }
}
