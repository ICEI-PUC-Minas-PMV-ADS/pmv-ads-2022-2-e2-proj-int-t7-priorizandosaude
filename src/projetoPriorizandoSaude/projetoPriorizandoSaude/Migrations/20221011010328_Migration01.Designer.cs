﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using projetoPriorizandoSaude.Data;

namespace projetoPriorizandoSaude.Migrations
{
    [DbContext(typeof(ContextPriorizandoSaude))]
    [Migration("20221011010328_Migration01")]
    partial class Migration01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("projetoPriorizandoSaude.Models.Agenda", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataHoraFimConsulta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraInicioConsulta")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("MedicoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MedicoId");

                    b.ToTable("Agenda");
                });

            modelBuilder.Entity("projetoPriorizandoSaude.Models.Consulta", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AgendaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PacienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("StatusConsulta")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AgendaId");

                    b.HasIndex("PacienteId");

                    b.ToTable("Consulta");
                });

            modelBuilder.Entity("projetoPriorizandoSaude.Models.Medico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CRM")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Especialidade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("projetoPriorizandoSaude.Models.Paciente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CPF")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("projetoPriorizandoSaude.Models.Agenda", b =>
                {
                    b.HasOne("projetoPriorizandoSaude.Models.Medico", "Medico")
                        .WithMany("Agendas")
                        .HasForeignKey("MedicoId");

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("projetoPriorizandoSaude.Models.Consulta", b =>
                {
                    b.HasOne("projetoPriorizandoSaude.Models.Agenda", "Agenda")
                        .WithMany("Consultas")
                        .HasForeignKey("AgendaId");

                    b.HasOne("projetoPriorizandoSaude.Models.Paciente", "Paciente")
                        .WithMany("Consultas")
                        .HasForeignKey("PacienteId");

                    b.Navigation("Agenda");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("projetoPriorizandoSaude.Models.Agenda", b =>
                {
                    b.Navigation("Consultas");
                });

            modelBuilder.Entity("projetoPriorizandoSaude.Models.Medico", b =>
                {
                    b.Navigation("Agendas");
                });

            modelBuilder.Entity("projetoPriorizandoSaude.Models.Paciente", b =>
                {
                    b.Navigation("Consultas");
                });
#pragma warning restore 612, 618
        }
    }
}
