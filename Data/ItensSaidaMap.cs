using GerenciadorEstoque.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorEstoque.Data
{
    public class ItensSaidaMap : IEntityTypeConfiguration<ItensSaida>
    {
        public void Configure(EntityTypeBuilder<ItensSaida> builder)
        {
            builder.Property(model => model.QtdProduto).HasColumnType("float");
            builder.Property(model => model.ValorUnitario).HasColumnType("money");
            builder.HasOne(model => model.Saida).WithMany(model => model.ItensSaida).HasForeignKey(model => model.SaidaId);
        }
    }
}
