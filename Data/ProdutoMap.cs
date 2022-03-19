using GerenciadorEstoque.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorEstoque.Data
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.Property(model => model.CodBarras).HasColumnType("varchar(15)");
            builder.Property(model => model.Descricao).HasColumnType("varchar(100)").IsRequired();
            builder.Property(model => model.PrecoCusto).HasColumnType("money");
            builder.Property(model => model.PrecoVenda).HasColumnType("money");
            builder.Property(model => model.Estoque).HasColumnType("float");
            builder.Property(model => model.UniMedida).HasColumnType("varchar(5)").IsRequired();
            builder.Property(model => model.DataCadastro).HasColumnType("datetime").HasDefaultValueSql("getdate()");
            builder.Property(model => model.UltimaAlteracao).HasColumnType("datetime").HasDefaultValueSql("getdate()");
        }
    }
}
