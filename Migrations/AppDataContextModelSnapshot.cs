﻿// <auto-generated />
using System;
using GerenciadorEstoque.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GerenciadorEstoque.Migrations
{
    [DbContext(typeof(AppDataContext))]
    partial class AppDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GerenciadorEstoque.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("GerenciadorEstoque.Models.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("char(2)");

                    b.HasKey("EnderecoId");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("GerenciadorEstoque.Models.Entrada", b =>
                {
                    b.Property<int>("EntradaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Acrescimo")
                        .HasColumnType("money");

                    b.Property<DateTime>("DataEmissao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Desconto")
                        .HasColumnType("money");

                    b.Property<int>("FornecedorId")
                        .HasColumnType("int");

                    b.Property<string>("InformacoesAdicionais")
                        .HasColumnType("varchar(MAX)");

                    b.Property<string>("NroNota")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("QtdItens")
                        .HasColumnType("int");

                    b.Property<int>("QtdProdutos")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalEntrada")
                        .HasColumnType("money");

                    b.HasKey("EntradaId");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Entrada");
                });

            modelBuilder.Entity("GerenciadorEstoque.Models.Fornecedor", b =>
                {
                    b.Property<int>("FornecedorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("FornecedorId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("GerenciadorEstoque.Models.ItensEntrada", b =>
                {
                    b.Property<int>("ItensEntradaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EntradaId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<double>("QtdProduto")
                        .HasColumnType("float");

                    b.Property<decimal>("ValorUnitario")
                        .HasColumnType("money");

                    b.HasKey("ItensEntradaId");

                    b.HasIndex("EntradaId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ItensEntrada");
                });

            modelBuilder.Entity("GerenciadorEstoque.Models.ItensSaida", b =>
                {
                    b.Property<int>("ItensSaidaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<double>("QtdProduto")
                        .HasColumnType("float");

                    b.Property<int>("SaidaId")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorUnitario")
                        .HasColumnType("money");

                    b.HasKey("ItensSaidaId");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("SaidaId");

                    b.ToTable("ItensSaida");
                });

            modelBuilder.Entity("GerenciadorEstoque.Models.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<int?>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("CodBarras")
                        .HasColumnType("varchar(15)");

                    b.Property<DateTime>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<double>("Estoque")
                        .HasColumnType("float");

                    b.Property<decimal>("PrecoCusto")
                        .HasColumnType("money");

                    b.Property<decimal>("PrecoVenda")
                        .HasColumnType("money");

                    b.Property<DateTime>("UltimaAlteracao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("UniMedida")
                        .IsRequired()
                        .HasColumnType("varchar(5)");

                    b.HasKey("ProdutoId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("GerenciadorEstoque.Models.Saida", b =>
                {
                    b.Property<int>("SaidaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Acrescimo")
                        .HasColumnType("money");

                    b.Property<DateTime>("DataEmissao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataSaida")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Desconto")
                        .HasColumnType("money");

                    b.Property<string>("InformacoesAdicionais")
                        .HasColumnType("varchar(MAX)");

                    b.Property<string>("NroNota")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("QtdItens")
                        .HasColumnType("int");

                    b.Property<int>("QtdProdutos")
                        .HasColumnType("int");

                    b.Property<int>("SolicitanteId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalSaida")
                        .HasColumnType("money");

                    b.HasKey("SaidaId");

                    b.HasIndex("SolicitanteId");

                    b.ToTable("Saida");
                });

            modelBuilder.Entity("GerenciadorEstoque.Models.Solicitante", b =>
                {
                    b.Property<int>("SolicitanteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(18)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(16)");

                    b.HasKey("SolicitanteId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Solicitante");
                });

            modelBuilder.Entity("GerenciadorEstoque.Models.Entrada", b =>
                {
                    b.HasOne("GerenciadorEstoque.Models.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("GerenciadorEstoque.Models.Fornecedor", b =>
                {
                    b.HasOne("GerenciadorEstoque.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("GerenciadorEstoque.Models.ItensEntrada", b =>
                {
                    b.HasOne("GerenciadorEstoque.Models.Entrada", "Entrada")
                        .WithMany("ItensEntrada")
                        .HasForeignKey("EntradaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciadorEstoque.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entrada");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("GerenciadorEstoque.Models.ItensSaida", b =>
                {
                    b.HasOne("GerenciadorEstoque.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciadorEstoque.Models.Saida", "Saida")
                        .WithMany("ItensSaida")
                        .HasForeignKey("SaidaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");

                    b.Navigation("Saida");
                });

            modelBuilder.Entity("GerenciadorEstoque.Models.Produto", b =>
                {
                    b.HasOne("GerenciadorEstoque.Models.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaId");

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("GerenciadorEstoque.Models.Saida", b =>
                {
                    b.HasOne("GerenciadorEstoque.Models.Solicitante", "Solicitante")
                        .WithMany()
                        .HasForeignKey("SolicitanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Solicitante");
                });

            modelBuilder.Entity("GerenciadorEstoque.Models.Solicitante", b =>
                {
                    b.HasOne("GerenciadorEstoque.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("GerenciadorEstoque.Models.Categoria", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("GerenciadorEstoque.Models.Entrada", b =>
                {
                    b.Navigation("ItensEntrada");
                });

            modelBuilder.Entity("GerenciadorEstoque.Models.Saida", b =>
                {
                    b.Navigation("ItensSaida");
                });
#pragma warning restore 612, 618
        }
    }
}
