using GerenciadorEstoque.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorEstoque.Data
{
    public class ItensEntradaMap : IEntityTypeConfiguration<ItensEntrada>
    {
        public void Configure(EntityTypeBuilder<ItensEntrada> builder)
        {
            builder.Property(model => model.QtdProduto).HasColumnType("float");
            builder.Property(model => model.ValorUnitario).HasColumnType("money");
            builder.HasOne(model => model.Entrada).WithMany(model => model.ItensEntrada).HasForeignKey(model => model.EntradaId);
        }
    }
}
