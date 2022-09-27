using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class teste2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCriacao",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Cursos");

            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "Cursos",
                newName: "Referencia");

            migrationBuilder.RenameColumn(
                name: "Imagem",
                table: "Cursos",
                newName: "Nome");

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Cursos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Cursos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Cursos");

            migrationBuilder.RenameColumn(
                name: "Referencia",
                table: "Cursos",
                newName: "Titulo");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Cursos",
                newName: "Imagem");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCriacao",
                table: "Cursos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Cursos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
