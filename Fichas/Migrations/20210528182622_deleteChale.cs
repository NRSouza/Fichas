using Microsoft.EntityFrameworkCore.Migrations;

namespace Fichas.Migrations
{
    public partial class deleteChale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Chale",
                table: "Acampante");

            migrationBuilder.DropColumn(
                name: "TurmaNR",
                table: "Acampante");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Chale",
                table: "Acampante",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TurmaNR",
                table: "Acampante",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
