using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace docspider.Migrations
{
    public partial class Alter_Pessoa_Audited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CriadoEm",
                table: "Pessoa",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<long>(
                name: "CriadoPor",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ExcluidoPor",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExcluidoEm",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Pessoa",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Excluido",
                table: "Pessoa",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CriadoEm",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "CriadoPor",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "ExcluidoPor",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "ExcluidoEm",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "Excluido",
                table: "Pessoa");
        }
    }
}
