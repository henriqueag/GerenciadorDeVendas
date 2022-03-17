using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciadorDeVendas.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categoria",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoria", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataNascimento = table.Column<DateTime>(type: "datetime", nullable: true),
                    QtdCompras = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "varchar(80)", nullable: false),
                    CPF = table.Column<string>(type: "varchar(15)", nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: true),
                    Telefone = table.Column<string>(type: "varchar(16)", nullable: false),
                    Email = table.Column<string>(type: "varchar(80)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "formasPagamento",
                columns: table => new
                {
                    FormasPagamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar(50)", nullable: false),
                    PermiteAcrescimo = table.Column<bool>(type: "bit", nullable: false),
                    PermiteDesconto = table.Column<bool>(type: "bit", nullable: false),
                    TipoPagamento = table.Column<string>(type: "varchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formasPagamento", x => x.FormasPagamentoId);
                });

            migrationBuilder.CreateTable(
                name: "vendedor",
                columns: table => new
                {
                    VendedorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comissao = table.Column<decimal>(type: "money", nullable: false),
                    QtdVendas = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "varchar(80)", nullable: false),
                    CPF = table.Column<string>(type: "varchar(15)", nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: true),
                    Telefone = table.Column<string>(type: "varchar(16)", nullable: false),
                    Email = table.Column<string>(type: "varchar(80)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vendedor", x => x.VendedorId);
                });

            migrationBuilder.CreateTable(
                name: "produtos",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodBarras = table.Column<string>(type: "varchar(15)", nullable: true),
                    Descricao = table.Column<string>(type: "varchar(80)", nullable: false),
                    PrecoCusto = table.Column<decimal>(type: "money", nullable: false),
                    PrecoVenda = table.Column<decimal>(type: "money", nullable: false),
                    Estoque = table.Column<double>(type: "float", nullable: false),
                    Marca = table.Column<string>(type: "varchar(50)", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    UltimaAlteracao = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    CategoriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos", x => x.ProdutoId);
                    table.ForeignKey(
                        name: "FK_produtos_categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "categoria",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "endereco",
                columns: table => new
                {
                    EnderecoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cep = table.Column<string>(type: "varchar(10)", nullable: false),
                    Logradouro = table.Column<string>(type: "varchar(60)", nullable: false),
                    Complemento = table.Column<string>(type: "varchar(30)", nullable: true),
                    Bairro = table.Column<string>(type: "varchar(50)", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(50)", nullable: false),
                    Uf = table.Column<string>(type: "char(2)", nullable: false),
                    DDD = table.Column<string>(type: "varchar(3)", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_endereco", x => x.EnderecoId);
                    table.ForeignKey(
                        name: "FK_endereco_cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "vendas",
                columns: table => new
                {
                    VendaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    VendedorId = table.Column<int>(type: "int", nullable: false),
                    FormasPagamentoId = table.Column<int>(type: "int", nullable: false),
                    TipoPagamento = table.Column<int>(type: "int", nullable: false),
                    Desconto = table.Column<decimal>(type: "money", nullable: false),
                    Acrescimo = table.Column<decimal>(type: "money", nullable: false),
                    TotalGeral = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vendas", x => x.VendaId);
                    table.ForeignKey(
                        name: "FK_vendas_cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vendas_formasPagamento_FormasPagamentoId",
                        column: x => x.FormasPagamentoId,
                        principalTable: "formasPagamento",
                        principalColumn: "FormasPagamentoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vendas_vendedor_VendedorId",
                        column: x => x.VendedorId,
                        principalTable: "vendedor",
                        principalColumn: "VendedorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "itensDaVenda",
                columns: table => new
                {
                    VendaId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    QtdPorProduto = table.Column<double>(type: "float", nullable: false),
                    ValorUnitario = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itensDaVenda", x => x.VendaId);
                    table.ForeignKey(
                        name: "FK_itensDaVenda_produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "produtos",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_itensDaVenda_vendas_VendaId",
                        column: x => x.VendaId,
                        principalTable: "vendas",
                        principalColumn: "VendaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_endereco_ClienteId",
                table: "endereco",
                column: "ClienteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_itensDaVenda_ProdutoId",
                table: "itensDaVenda",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_produtos_CategoriaId",
                table: "produtos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_vendas_ClienteId",
                table: "vendas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_vendas_FormasPagamentoId",
                table: "vendas",
                column: "FormasPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_vendas_VendedorId",
                table: "vendas",
                column: "VendedorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "endereco");

            migrationBuilder.DropTable(
                name: "itensDaVenda");

            migrationBuilder.DropTable(
                name: "produtos");

            migrationBuilder.DropTable(
                name: "vendas");

            migrationBuilder.DropTable(
                name: "categoria");

            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "formasPagamento");

            migrationBuilder.DropTable(
                name: "vendedor");
        }
    }
}
