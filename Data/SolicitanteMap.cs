using GerenciadorEstoque.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorEstoque.Data
{
    public class SolicitanteMap : IEntityTypeConfiguration<Solicitante>
    {
        public void Configure(EntityTypeBuilder<Solicitante> builder)
        {
            builder.Property(model => model.Nome).HasColumnType("varchar(80)").IsRequired();
            builder.Property(model => model.CPF).HasColumnType("varchar(18)").IsRequired();
            builder.Property(model => model.Telefone).HasColumnType("varchar(16)").IsRequired();
            builder.Property(model => model.Email).HasColumnType("varchar(80)").IsRequired();
        }
    }
}
