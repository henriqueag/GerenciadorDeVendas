using GerenciadorDeVendas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorDeVendas.Data
{
    public class VendaMap : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder.ToTable("vendas");
            builder.Property(model => model.Desconto).HasColumnType("money");
            builder.Property(model => model.Acrescimo).HasColumnType("money");
            builder.Property(model => model.TotalGeral).HasColumnType("money");
            builder.HasMany(model => model.ItensDaVenda).WithOne(model => model.Venda).HasForeignKey(model => model.VendaId);
        }
    }
}
