using Microsoft.EntityFrameworkCore.Migrations;

namespace Fichas.Migrations
{
    public partial class Undad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Unidade",
                table: "Acampante",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Unidade",
                table: "Acampante");
        }
    }
}
