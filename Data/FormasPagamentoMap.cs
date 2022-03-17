using GerenciadorDeVendas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorDeVendas.Data
{
    public class FormasPagamentoMap : IEntityTypeConfiguration<FormasPagamento>
    {
        public void Configure(EntityTypeBuilder<FormasPagamento> builder)
        {
            builder.ToTable("formasPagamento");
            builder.Property(model => model.Descricao).HasColumnType("varchar(50)").IsRequired();
            builder.Property(model => model.TipoPagamento).HasColumnType("varchar(30)").IsRequired();
        }
    }
}
