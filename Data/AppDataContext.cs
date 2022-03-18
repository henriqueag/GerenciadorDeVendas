using System;
using GerenciadorEstoque.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorEstoque.Data
{
    public class AppDataContext : DbContext
    {
        public DbSet<Usuario> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        public AppDataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
