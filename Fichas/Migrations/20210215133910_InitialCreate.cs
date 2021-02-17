using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fichas.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responsavel",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    codResponsavel = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    FichaRespondida = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsavel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Acampante",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    codPessoa = table.Column<int>(nullable: false),
                    codAcampante = table.Column<int>(nullable: false),
                    ResponsavelID = table.Column<Guid>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    FichaRespondida = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acampante", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Acampante_Responsavel_ResponsavelID",
                        column: x => x.ResponsavelID,
                        principalTable: "Responsavel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ficha",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ResponsavelID = table.Column<Guid>(nullable: true),
                    AcampanteID = table.Column<Guid>(nullable: true),
                    Peso = table.Column<double>(nullable: false),
                    Altura = table.Column<double>(nullable: false),
                    Tip_Sanguineo = table.Column<string>(nullable: true),
                    Convenio = table.Column<string>(nullable: true),
                    Nome_Pediatra_Contato = table.Column<string>(nullable: true),
                    Nadar = table.Column<bool>(nullable: false),
                    Boia = table.Column<bool>(nullable: false),
                    Acomp_Psicologico = table.Column<bool>(nullable: false),
                    Motivo_Acomp_Psicologico = table.Column<string>(nullable: true),
                    Vacinas_Validas = table.Column<bool>(nullable: false),
                    H1N1 = table.Column<bool>(nullable: false),
                    Dat_H1N1 = table.Column<DateTime>(nullable: false),
                    MenigiteC = table.Column<bool>(nullable: false),
                    Dat_MenigiteC = table.Column<DateTime>(nullable: false),
                    BelicheInferior = table.Column<bool>(nullable: false),
                    Aparelho_Dental = table.Column<bool>(nullable: false),
                    Dramin = table.Column<bool>(nullable: false),
                    Vonal = table.Column<bool>(nullable: false),
                    Orientacao_Febre = table.Column<string>(nullable: true),
                    Orientacao_Barriga = table.Column<string>(nullable: true),
                    Orientacao_Cabeca = table.Column<string>(nullable: true),
                    Orientacao_Ouvido = table.Column<string>(nullable: true),
                    Orientacao_Colica = table.Column<string>(nullable: true),
                    Orientacao_Garganta = table.Column<string>(nullable: true),
                    Diabetes = table.Column<bool>(nullable: false),
                    Convulsao = table.Column<bool>(nullable: false),
                    Asma = table.Column<bool>(nullable: false),
                    Bronquite = table.Column<bool>(nullable: false),
                    Infeccao_Recente = table.Column<bool>(nullable: false),
                    Enurese_Noturna = table.Column<bool>(nullable: false),
                    Sonambulismo = table.Column<bool>(nullable: false),
                    RestricaoAttFisica = table.Column<bool>(nullable: false),
                    Obs_RestricaoAttFisica = table.Column<string>(nullable: true),
                    Alergia_Medicamento = table.Column<bool>(nullable: false),
                    Obs_Alergia_Medicamento = table.Column<string>(nullable: true),
                    Necessidade_Especial = table.Column<bool>(nullable: false),
                    Obs_Necessidade_Especial = table.Column<string>(nullable: true),
                    Restricao_Alimentar = table.Column<bool>(nullable: false),
                    Obs_Restricao_Alimentar = table.Column<string>(nullable: true),
                    Medo_Fobia = table.Column<bool>(nullable: false),
                    Obs_Medo_Fobia = table.Column<string>(nullable: true),
                    OcorrenciaMedica = table.Column<string>(nullable: true),
                    Obs_Geral = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ficha", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ficha_Acampante_AcampanteID",
                        column: x => x.AcampanteID,
                        principalTable: "Acampante",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ficha_Responsavel_ResponsavelID",
                        column: x => x.ResponsavelID,
                        principalTable: "Responsavel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Acampante_ResponsavelID",
                table: "Acampante",
                column: "ResponsavelID");

            migrationBuilder.CreateIndex(
                name: "IX_Ficha_AcampanteID",
                table: "Ficha",
                column: "AcampanteID");

            migrationBuilder.CreateIndex(
                name: "IX_Ficha_ResponsavelID",
                table: "Ficha",
                column: "ResponsavelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ficha");

            migrationBuilder.DropTable(
                name: "Acampante");

            migrationBuilder.DropTable(
                name: "Responsavel");
        }
    }
}
