using Microsoft.EntityFrameworkCore.Migrations;

namespace Fichas.Migrations
{
    public partial class MudancaModelsGUID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FichaRespondida",
                table: "Responsavel");

            migrationBuilder.AlterColumn<long>(
                name: "codAcampante",
                table: "Acampante",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "FichaRespondida",
                table: "Responsavel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "codAcampante",
                table: "Acampante",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));
        }
    }
}
