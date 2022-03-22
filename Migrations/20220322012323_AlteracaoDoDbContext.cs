using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciadorEstoque.Migrations
{
    public partial class AlteracaoDoDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrada_Fornecedor_FornecedorId",
                table: "Entrada");

            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedor_Endereco_EnderecoId",
                table: "Fornecedor");

            migrationBuilder.DropForeignKey(
                name: "FK_ItensEntrada_Entrada_EntradaId",
                table: "ItensEntrada");

            migrationBuilder.DropForeignKey(
                name: "FK_ItensEntrada_Produto_ProdutoId",
                table: "ItensEntrada");

            migrationBuilder.DropForeignKey(
                name: "FK_ItensSaida_Produto_ProdutoId",
                table: "ItensSaida");

            migrationBuilder.DropForeignKey(
                name: "FK_ItensSaida_Saida_SaidaId",
                table: "ItensSaida");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Categoria_CategoriaId",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Saida_Solicitante_SolicitanteId",
                table: "Saida");

            migrationBuilder.DropForeignKey(
                name: "FK_Solicitante_Endereco_EnderecoId",
                table: "Solicitante");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Solicitante",
                table: "Solicitante");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Saida",
                table: "Saida");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produto",
                table: "Produto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItensSaida",
                table: "ItensSaida");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItensEntrada",
                table: "ItensEntrada");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fornecedor",
                table: "Fornecedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Entrada",
                table: "Entrada");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria");

            migrationBuilder.RenameTable(
                name: "Solicitante",
                newName: "Solicitantes");

            migrationBuilder.RenameTable(
                name: "Saida",
                newName: "Saidas");

            migrationBuilder.RenameTable(
                name: "Produto",
                newName: "Produtos");

            migrationBuilder.RenameTable(
                name: "ItensSaida",
                newName: "ItensSaidas");

            migrationBuilder.RenameTable(
                name: "ItensEntrada",
                newName: "ItensEntradas");

            migrationBuilder.RenameTable(
                name: "Fornecedor",
                newName: "Fornecedores");

            migrationBuilder.RenameTable(
                name: "Entrada",
                newName: "Entradas");

            migrationBuilder.RenameTable(
                name: "Endereco",
                newName: "Enderecos");

            migrationBuilder.RenameTable(
                name: "Categoria",
                newName: "Categorias");

            migrationBuilder.RenameIndex(
                name: "IX_Solicitante_EnderecoId",
                table: "Solicitantes",
                newName: "IX_Solicitantes_EnderecoId");

            migrationBuilder.RenameIndex(
                name: "IX_Saida_SolicitanteId",
                table: "Saidas",
                newName: "IX_Saidas_SolicitanteId");

            migrationBuilder.RenameIndex(
                name: "IX_Produto_CategoriaId",
                table: "Produtos",
                newName: "IX_Produtos_CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_ItensSaida_SaidaId",
                table: "ItensSaidas",
                newName: "IX_ItensSaidas_SaidaId");

            migrationBuilder.RenameIndex(
                name: "IX_ItensSaida_ProdutoId",
                table: "ItensSaidas",
                newName: "IX_ItensSaidas_ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_ItensEntrada_ProdutoId",
                table: "ItensEntradas",
                newName: "IX_ItensEntradas_ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_ItensEntrada_EntradaId",
                table: "ItensEntradas",
                newName: "IX_ItensEntradas_EntradaId");

            migrationBuilder.RenameIndex(
                name: "IX_Fornecedor_EnderecoId",
                table: "Fornecedores",
                newName: "IX_Fornecedores_EnderecoId");

            migrationBuilder.RenameIndex(
                name: "IX_Entrada_FornecedorId",
                table: "Entradas",
                newName: "IX_Entradas_FornecedorId");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Solicitantes",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Fornecedores",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Solicitantes",
                table: "Solicitantes",
                column: "SolicitanteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Saidas",
                table: "Saidas",
                column: "SaidaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos",
                column: "ProdutoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItensSaidas",
                table: "ItensSaidas",
                column: "ItensSaidaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItensEntradas",
                table: "ItensEntradas",
                column: "ItensEntradaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fornecedores",
                table: "Fornecedores",
                column: "FornecedorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entradas",
                table: "Entradas",
                column: "EntradaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos",
                column: "EnderecoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias",
                column: "CategoriaId");

            migrationBuilder.CreateTable(
                name: "Usuarios",
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
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Entradas_Fornecedores_FornecedorId",
                table: "Entradas",
                column: "FornecedorId",
                principalTable: "Fornecedores",
                principalColumn: "FornecedorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedores_Enderecos_EnderecoId",
                table: "Fornecedores",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "EnderecoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItensEntradas_Entradas_EntradaId",
                table: "ItensEntradas",
                column: "EntradaId",
                principalTable: "Entradas",
                principalColumn: "EntradaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItensEntradas_Produtos_ProdutoId",
                table: "ItensEntradas",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "ProdutoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItensSaidas_Produtos_ProdutoId",
                table: "ItensSaidas",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "ProdutoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItensSaidas_Saidas_SaidaId",
                table: "ItensSaidas",
                column: "SaidaId",
                principalTable: "Saidas",
                principalColumn: "SaidaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categorias_CategoriaId",
                table: "Produtos",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Saidas_Solicitantes_SolicitanteId",
                table: "Saidas",
                column: "SolicitanteId",
                principalTable: "Solicitantes",
                principalColumn: "SolicitanteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitantes_Enderecos_EnderecoId",
                table: "Solicitantes",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "EnderecoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entradas_Fornecedores_FornecedorId",
                table: "Entradas");

            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedores_Enderecos_EnderecoId",
                table: "Fornecedores");

            migrationBuilder.DropForeignKey(
                name: "FK_ItensEntradas_Entradas_EntradaId",
                table: "ItensEntradas");

            migrationBuilder.DropForeignKey(
                name: "FK_ItensEntradas_Produtos_ProdutoId",
                table: "ItensEntradas");

            migrationBuilder.DropForeignKey(
                name: "FK_ItensSaidas_Produtos_ProdutoId",
                table: "ItensSaidas");

            migrationBuilder.DropForeignKey(
                name: "FK_ItensSaidas_Saidas_SaidaId",
                table: "ItensSaidas");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categorias_CategoriaId",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Saidas_Solicitantes_SolicitanteId",
                table: "Saidas");

            migrationBuilder.DropForeignKey(
                name: "FK_Solicitantes_Enderecos_EnderecoId",
                table: "Solicitantes");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Solicitantes",
                table: "Solicitantes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Saidas",
                table: "Saidas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItensSaidas",
                table: "ItensSaidas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItensEntradas",
                table: "ItensEntradas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fornecedores",
                table: "Fornecedores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Entradas",
                table: "Entradas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Solicitantes");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Fornecedores");

            migrationBuilder.RenameTable(
                name: "Solicitantes",
                newName: "Solicitante");

            migrationBuilder.RenameTable(
                name: "Saidas",
                newName: "Saida");

            migrationBuilder.RenameTable(
                name: "Produtos",
                newName: "Produto");

            migrationBuilder.RenameTable(
                name: "ItensSaidas",
                newName: "ItensSaida");

            migrationBuilder.RenameTable(
                name: "ItensEntradas",
                newName: "ItensEntrada");

            migrationBuilder.RenameTable(
                name: "Fornecedores",
                newName: "Fornecedor");

            migrationBuilder.RenameTable(
                name: "Entradas",
                newName: "Entrada");

            migrationBuilder.RenameTable(
                name: "Enderecos",
                newName: "Endereco");

            migrationBuilder.RenameTable(
                name: "Categorias",
                newName: "Categoria");

            migrationBuilder.RenameIndex(
                name: "IX_Solicitantes_EnderecoId",
                table: "Solicitante",
                newName: "IX_Solicitante_EnderecoId");

            migrationBuilder.RenameIndex(
                name: "IX_Saidas_SolicitanteId",
                table: "Saida",
                newName: "IX_Saida_SolicitanteId");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_CategoriaId",
                table: "Produto",
                newName: "IX_Produto_CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_ItensSaidas_SaidaId",
                table: "ItensSaida",
                newName: "IX_ItensSaida_SaidaId");

            migrationBuilder.RenameIndex(
                name: "IX_ItensSaidas_ProdutoId",
                table: "ItensSaida",
                newName: "IX_ItensSaida_ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_ItensEntradas_ProdutoId",
                table: "ItensEntrada",
                newName: "IX_ItensEntrada_ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_ItensEntradas_EntradaId",
                table: "ItensEntrada",
                newName: "IX_ItensEntrada_EntradaId");

            migrationBuilder.RenameIndex(
                name: "IX_Fornecedores_EnderecoId",
                table: "Fornecedor",
                newName: "IX_Fornecedor_EnderecoId");

            migrationBuilder.RenameIndex(
                name: "IX_Entradas_FornecedorId",
                table: "Entrada",
                newName: "IX_Entrada_FornecedorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Solicitante",
                table: "Solicitante",
                column: "SolicitanteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Saida",
                table: "Saida",
                column: "SaidaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produto",
                table: "Produto",
                column: "ProdutoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItensSaida",
                table: "ItensSaida",
                column: "ItensSaidaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItensEntrada",
                table: "ItensEntrada",
                column: "ItensEntradaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fornecedor",
                table: "Fornecedor",
                column: "FornecedorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entrada",
                table: "Entrada",
                column: "EntradaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco",
                column: "EnderecoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entrada_Fornecedor_FornecedorId",
                table: "Entrada",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "FornecedorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedor_Endereco_EnderecoId",
                table: "Fornecedor",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "EnderecoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItensEntrada_Entrada_EntradaId",
                table: "ItensEntrada",
                column: "EntradaId",
                principalTable: "Entrada",
                principalColumn: "EntradaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItensEntrada_Produto_ProdutoId",
                table: "ItensEntrada",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "ProdutoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItensSaida_Produto_ProdutoId",
                table: "ItensSaida",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "ProdutoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItensSaida_Saida_SaidaId",
                table: "ItensSaida",
                column: "SaidaId",
                principalTable: "Saida",
                principalColumn: "SaidaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Categoria_CategoriaId",
                table: "Produto",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Saida_Solicitante_SolicitanteId",
                table: "Saida",
                column: "SolicitanteId",
                principalTable: "Solicitante",
                principalColumn: "SolicitanteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitante_Endereco_EnderecoId",
                table: "Solicitante",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "EnderecoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
