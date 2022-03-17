using GerenciadorDeVendas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorDeVendas.Data
{
    public class ItensDaVendaMap : IEntityTypeConfiguration<ItensDaVenda>
    {
        public void Configure(EntityTypeBuilder<ItensDaVenda> builder)
        {
            builder.ToTable("itensDaVenda");
            builder.HasKey(model => model.VendaId);
            builder.Property(model => model.VendaId).ValueGeneratedNever();
            builder.Property(model => model.ValorUnitario).HasColumnType("money").IsRequired();
        }
    }
}
