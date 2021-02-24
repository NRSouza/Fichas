using Microsoft.EntityFrameworkCore.Migrations;

namespace Fichas.Migrations
{
    public partial class TratamentoABCD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tratamento_Asma",
                table: "Ficha",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tratamento_Bronquite",
                table: "Ficha",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tratamento_Convulsao",
                table: "Ficha",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tratamento_Diabetes",
                table: "Ficha",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tratamento_Asma",
                table: "Ficha");

            migrationBuilder.DropColumn(
                name: "Tratamento_Bronquite",
                table: "Ficha");

            migrationBuilder.DropColumn(
                name: "Tratamento_Convulsao",
                table: "Ficha");

            migrationBuilder.DropColumn(
                name: "Tratamento_Diabetes",
                table: "Ficha");
        }
    }
}
