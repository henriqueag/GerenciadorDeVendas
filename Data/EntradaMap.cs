using GerenciadorEstoque.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorEstoque.Data
{
    public class EntradaMap : IEntityTypeConfiguration<Entrada>
    {
        public void Configure(EntityTypeBuilder<Entrada> builder)
        {
            builder.Property(model => model.NroNota).HasColumnType("varchar(20)").IsRequired();
            builder.Property(model => model.TotalEntrada).HasColumnType("money");
            builder.Property(model => model.Acrescimo).HasColumnType("money");
            builder.Property(model => model.Desconto).HasColumnType("money");
            builder.Property(model => model.InformacoesAdicionais).HasColumnType("varchar(MAX)");
        }
    }
}
