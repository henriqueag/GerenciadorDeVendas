using GerenciadorDeVendas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorDeVendas.Data
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("produtos");
            builder.Property(model => model.Descricao).HasColumnType("varchar(80)").IsRequired();
            builder.Property(model => model.CodBarras).HasColumnType("varchar(15)");
            builder.Property(model => model.PrecoCusto).HasColumnType("money").IsRequired();
            builder.Property(model => model.PrecoVenda).HasColumnType("money").IsRequired();
            builder.Property(model => model.Estoque).HasColumnType("float").IsRequired();
            builder.Property(model => model.Marca).HasColumnType("varchar(50)");
            builder.Property(model => model.DataCadastro).HasColumnType("datetime").HasDefaultValueSql("getdate()");
            builder.Property(model => model.UltimaAlteracao).HasColumnType("datetime").HasDefaultValueSql("getdate()");
            builder.HasOne(model => model.Categoria).WithMany(model => model.Produtos);
        }
    }
}
