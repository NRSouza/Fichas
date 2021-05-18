using Microsoft.EntityFrameworkCore.Migrations;

namespace Fichas.Migrations
{
    public partial class Impresa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "FlgImpressao",
                table: "Acampante",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FlgImpressao",
                table: "Acampante");
        }
    }
}
