using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciadorEstoque.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    EnderecoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cep = table.Column<string>(type: "varchar(10)", nullable: false),
                    Logradouro = table.Column<string>(type: "varchar(60)", nullable: false),
                    Complemento = table.Column<string>(type: "varchar(30)", nullable: true),
                    Bairro = table.Column<string>(type: "varchar(40)", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(60)", nullable: false),
                    Uf = table.Column<string>(type: "char(2)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.EnderecoId);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodBarras = table.Column<string>(type: "varchar(15)", nullable: true),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: false),
                    PrecoCusto = table.Column<decimal>(type: "money", nullable: false),
                    PrecoVenda = table.Column<decimal>(type: "money", nullable: false),
                    Estoque = table.Column<double>(type: "float", nullable: false),
                    UniMedida = table.Column<string>(type: "varchar(5)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    UltimaAlteracao = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    CategoriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.ProdutoId);
                    table.ForeignKey(
                        name: "FK_Produto_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    FornecedorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    CNPJ = table.Column<string>(type: "varchar(20)", nullable: false),
                    EnderecoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.FornecedorId);
                    table.ForeignKey(
                        name: "FK_Fornecedor_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "EnderecoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Solicitante",
                columns: table => new
                {
                    SolicitanteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(80)", nullable: false),
                    CPF = table.Column<string>(type: "varchar(18)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(16)", nullable: false),
                    Email = table.Column<string>(type: "varchar(80)", nullable: false),
                    EnderecoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitante", x => x.SolicitanteId);
                    table.ForeignKey(
                        name: "FK_Solicitante_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "EnderecoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entrada",
                columns: table => new
                {
                    EntradaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NroNota = table.Column<string>(type: "varchar(20)", nullable: false),
                    FornecedorId = table.Column<int>(type: "int", nullable: false),
                    DataEmissao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalEntrada = table.Column<decimal>(type: "money", nullable: false),
                    Acrescimo = table.Column<decimal>(type: "money", nullable: false),
                    Desconto = table.Column<decimal>(type: "money", nullable: false),
                    QtdProdutos = table.Column<int>(type: "int", nullable: false),
                    QtdItens = table.Column<int>(type: "int", nullable: false),
                    InformacoesAdicionais = table.Column<string>(type: "varchar(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrada", x => x.EntradaId);
                    table.ForeignKey(
                        name: "FK_Entrada_Fornecedor_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedor",
                        principalColumn: "FornecedorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Saida",
                columns: table => new
                {
                    SaidaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NroNota = table.Column<string>(type: "varchar(20)", nullable: false),
                    SolicitanteId = table.Column<int>(type: "int", nullable: false),
                    DataEmissao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataSaida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalSaida = table.Column<decimal>(type: "money", nullable: false),
                    Acrescimo = table.Column<decimal>(type: "money", nullable: false),
                    Desconto = table.Column<decimal>(type: "money", nullable: false),
                    QtdProdutos = table.Column<int>(type: "int", nullable: false),
                    QtdItens = table.Column<int>(type: "int", nullable: false),
                    InformacoesAdicionais = table.Column<string>(type: "varchar(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saida", x => x.SaidaId);
                    table.ForeignKey(
                        name: "FK_Saida_Solicitante_SolicitanteId",
                        column: x => x.SolicitanteId,
                        principalTable: "Solicitante",
                        principalColumn: "SolicitanteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItensEntrada",
                columns: table => new
                {
                    ItensEntradaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntradaId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    QtdProduto = table.Column<double>(type: "float", nullable: false),
                    ValorUnitario = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensEntrada", x => x.ItensEntradaId);
                    table.ForeignKey(
                        name: "FK_ItensEntrada_Entrada_EntradaId",
                        column: x => x.EntradaId,
                        principalTable: "Entrada",
                        principalColumn: "EntradaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItensEntrada_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItensSaida",
                columns: table => new
                {
                    ItensSaidaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaidaId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    QtdProduto = table.Column<double>(type: "float", nullable: false),
                    ValorUnitario = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensSaida", x => x.ItensSaidaId);
                    table.ForeignKey(
                        name: "FK_ItensSaida_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItensSaida_Saida_SaidaId",
                        column: x => x.SaidaId,
                        principalTable: "Saida",
                        principalColumn: "SaidaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entrada_FornecedorId",
                table: "Entrada",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_EnderecoId",
                table: "Fornecedor",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensEntrada_EntradaId",
                table: "ItensEntrada",
                column: "EntradaId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensEntrada_ProdutoId",
                table: "ItensEntrada",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensSaida_ProdutoId",
                table: "ItensSaida",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensSaida_SaidaId",
                table: "ItensSaida",
                column: "SaidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_CategoriaId",
                table: "Produto",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Saida_SolicitanteId",
                table: "Saida",
                column: "SolicitanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitante_EnderecoId",
                table: "Solicitante",
                column: "EnderecoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItensEntrada");

            migrationBuilder.DropTable(
                name: "ItensSaida");

            migrationBuilder.DropTable(
                name: "Entrada");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Saida");

            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Solicitante");

            migrationBuilder.DropTable(
                name: "Endereco");
        }
    }
}
