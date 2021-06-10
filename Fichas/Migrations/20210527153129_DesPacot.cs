using Microsoft.EntityFrameworkCore.Migrations;

namespace Fichas.Migrations
{
    public partial class DesPacot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DesPacote",
                table: "Acampante",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DesPacote",
                table: "Acampante");
        }
    }
}
