using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciadorEstoque.Migrations
{
    public partial class AdicaoDeClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Solicitante",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Fornecedor",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "varchar(30)", nullable: false),
                    Password = table.Column<string>(type: "varchar(110)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    Nome = table.Column<string>(type: "varchar(80)", nullable: false),
                    CPF = table.Column<string>(type: "varchar(18)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(16)", nullable: false),
                    Email = table.Column<string>(type: "varchar(80)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Solicitante");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Fornecedor");
        }
    }
}
