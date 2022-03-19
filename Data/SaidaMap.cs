using GerenciadorEstoque.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorEstoque.Data
{
    public class SaidaMap : IEntityTypeConfiguration<Saida>
    {
        public void Configure(EntityTypeBuilder<Saida> builder)
        {
            builder.Property(model => model.NroNota).HasColumnType("varchar(20)").IsRequired();
            builder.Property(model => model.TotalSaida).HasColumnType("money");
            builder.Property(model => model.Acrescimo).HasColumnType("money");
            builder.Property(model => model.Desconto).HasColumnType("money");
            builder.Property(model => model.InformacoesAdicionais).HasColumnType("varchar(MAX)");
        }
    }
}
