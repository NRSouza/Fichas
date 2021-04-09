using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fichas.Migrations
{
    public partial class Amigos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DatNascto",
                table: "Acampante",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateTable(
                name: "Terceiros",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terceiros", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Amigos",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    AcampanteID = table.Column<Guid>(nullable: true),
                    TerceirosID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amigos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Amigos_Acampante_AcampanteID",
                        column: x => x.AcampanteID,
                        principalTable: "Acampante",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Amigos_Terceiros_TerceirosID",
                        column: x => x.TerceirosID,
                        principalTable: "Terceiros",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Amigos_AcampanteID",
                table: "Amigos",
                column: "AcampanteID");

            migrationBuilder.CreateIndex(
                name: "IX_Amigos_TerceirosID",
                table: "Amigos",
                column: "TerceirosID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amigos");

            migrationBuilder.DropTable(
                name: "Terceiros");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DatNascto",
                table: "Acampante",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}
