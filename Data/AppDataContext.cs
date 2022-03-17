using System;
using GerenciadorDeVendas.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeVendas.Data
{
    public class AppDataContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        public AppDataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new VendedorMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new FormasPagamentoMap());
            modelBuilder.ApplyConfiguration(new ItensDaVendaMap());
            modelBuilder.ApplyConfiguration(new VendaMap());
        }
    }
}
