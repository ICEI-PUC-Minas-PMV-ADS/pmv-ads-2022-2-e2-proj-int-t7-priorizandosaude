using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoSegundoSemestre.Migrations
{
    public partial class AdicionandoEstruturaAgenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusAgenda",
                table: "Agendas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusAgenda",
                table: "Agendas");

        }
    }
}
