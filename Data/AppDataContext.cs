using GerenciadorEstoque.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorEstoque.Data
{
    public class AppDataContext : DbContext
    {
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Solicitante> Solicitantes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }        
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Entrada> Entradas { get; set; }
        public DbSet<Saida> Saidas { get; set; }
        public DbSet<ItensEntrada> ItensEntradas { get; set; }
        public DbSet<ItensSaida> ItensSaidas { get; set; }

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
            modelBuilder.ApplyConfiguration(new ItensEntradaMap());
            modelBuilder.ApplyConfiguration(new EntradaMap());
            modelBuilder.ApplyConfiguration(new ItensSaidaMap());
            modelBuilder.ApplyConfiguration(new SaidaMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
        }
    }
}
