using System;
using GerenciadorEstoque.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorEstoque.Data
{
    public class AppDataContext : DbContext
    {
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Endereco> Categorias { get; set; }
        public DbSet<Endereco> Fornecedores { get; set; }
        public DbSet<Endereco> Produtos { get; set; }
        public DbSet<Endereco> Solicitantes { get; set; }


        public AppDataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new FornecedorMap());
            modelBuilder.ApplyConfiguration(new SolicitanteMap());
        }
    }
}
