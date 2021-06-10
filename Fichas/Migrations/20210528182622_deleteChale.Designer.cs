﻿// <auto-generated />
using System;
using Fichas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fichas.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210528182622_deleteChale")]
    partial class deleteChale
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fichas.Models.Acampante", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DatNascto")
                        .HasColumnType("datetime2");

                    b.Property<string>("DesPacote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Equipe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FichaRespondida")
                        .HasColumnType("bit");

                    b.Property<bool>("FlgImpressao")
                        .HasColumnType("bit");

                    b.Property<bool>("FlgWhatsApp")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ResponsavelID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("codAcampante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("codPacote")
                        .HasColumnType("int");

                    b.Property<int>("codPessoa")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ResponsavelID");

                    b.ToTable("Acampante");
                });

            modelBuilder.Entity("Fichas.Models.Amigos", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AcampanteID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TerceirosID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("AcampanteID");

                    b.HasIndex("TerceirosID");

                    b.ToTable("Amigos");
                });

            modelBuilder.Entity("Fichas.Models.Ficha", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AcampanteID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Acomp_Psicologico")
                        .HasColumnType("bit");

                    b.Property<string>("Alergia_Medicamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Alopatia")
                        .HasColumnType("bit");

                    b.Property<double>("Altura")
                        .HasColumnType("float");

                    b.Property<bool>("Aparelho_Dental")
                        .HasColumnType("bit");

                    b.Property<bool>("Asma")
                        .HasColumnType("bit");

                    b.Property<bool>("Autorizacao_Atividades")
                        .HasColumnType("bit");

                    b.Property<bool>("BelicheInferior")
                        .HasColumnType("bit");

                    b.Property<bool>("Boia")
                        .HasColumnType("bit");

                    b.Property<bool>("Bronquite")
                        .HasColumnType("bit");

                    b.Property<string>("Convenio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Convulsao")
                        .HasColumnType("bit");

                    b.Property<bool>("Covid")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DatAtt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Dat_Covid")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Dat_H1N1")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Dat_MenigiteC")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Diabetes")
                        .HasColumnType("bit");

                    b.Property<bool>("Dramin")
                        .HasColumnType("bit");

                    b.Property<bool>("Enurese_Noturna")
                        .HasColumnType("bit");

                    b.Property<bool>("FreeKosher")
                        .HasColumnType("bit");

                    b.Property<bool>("H1N1")
                        .HasColumnType("bit");

                    b.Property<bool>("Homeopatia")
                        .HasColumnType("bit");

                    b.Property<bool>("Infeccao_Recente")
                        .HasColumnType("bit");

                    b.Property<bool>("Medo_Fobia")
                        .HasColumnType("bit");

                    b.Property<bool>("MenigiteC")
                        .HasColumnType("bit");

                    b.Property<string>("Motivo_Acomp_Psicologico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Nadar")
                        .HasColumnType("bit");

                    b.Property<string>("Necessidade_Especial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome_Pediatra_Contato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Obs_Alergia_Medicamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Obs_Autorizacao_Atividades")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Obs_Geral")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Obs_Medo_Fobia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Obs_Necessidade_Especial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Obs_RestricaoAttFisica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Obs_Restricao_Alimentar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OcorrenciaMedica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Orientacao_Barriga")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Orientacao_Cabeca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Orientacao_Colica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Orientacao_Febre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Orientacao_Garganta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Orientacao_Ouvido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Peso")
                        .HasColumnType("float");

                    b.Property<Guid?>("ResponsavelID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("RestricaoAttFisica")
                        .HasColumnType("bit");

                    b.Property<bool>("Restricao_Alimentar")
                        .HasColumnType("bit");

                    b.Property<bool>("Sonambulismo")
                        .HasColumnType("bit");

                    b.Property<string>("Tip_Sanguineo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tratamento_Asma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tratamento_Bronquite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tratamento_Convulsao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tratamento_Diabetes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Vacinas_Validas")
                        .HasColumnType("bit");

                    b.Property<bool>("Vonal")
                        .HasColumnType("bit");

                    b.Property<bool>("WeDoKosher")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("AcampanteID");

                    b.HasIndex("ResponsavelID");

                    b.ToTable("Ficha");
                });

            modelBuilder.Entity("Fichas.Models.Message", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("From")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Msg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("To")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ToSee")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("Fichas.Models.Responsavel", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("codResponsavel")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Responsavel");
                });

            modelBuilder.Entity("Fichas.Models.Terceiros", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Terceiros");
                });

            modelBuilder.Entity("Fichas.Models.Acampante", b =>
                {
                    b.HasOne("Fichas.Models.Responsavel", "Responsavel")
                        .WithMany()
                        .HasForeignKey("ResponsavelID");
                });

            modelBuilder.Entity("Fichas.Models.Amigos", b =>
                {
                    b.HasOne("Fichas.Models.Acampante", "Acampante")
                        .WithMany()
                        .HasForeignKey("AcampanteID");

                    b.HasOne("Fichas.Models.Terceiros", "Terceiros")
                        .WithMany()
                        .HasForeignKey("TerceirosID");
                });

            modelBuilder.Entity("Fichas.Models.Ficha", b =>
                {
                    b.HasOne("Fichas.Models.Acampante", "Acampante")
                        .WithMany()
                        .HasForeignKey("AcampanteID");

                    b.HasOne("Fichas.Models.Responsavel", "Responsavel")
                        .WithMany()
                        .HasForeignKey("ResponsavelID");
                });
#pragma warning restore 612, 618
        }
    }
}
