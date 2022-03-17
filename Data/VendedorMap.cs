using GerenciadorDeVendas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorDeVendas.Data
{
    public class VendedorMap : IEntityTypeConfiguration<Vendedor>
    {
        public void Configure(EntityTypeBuilder<Vendedor> builder)
        {
            builder.ToTable("vendedor");
            builder.Property(model => model.Nome).HasColumnType("varchar(80)").IsRequired();
            builder.Property(model => model.CPF).HasColumnType("varchar(15)").IsRequired();
            builder.Property(model => model.Telefone).HasColumnType("varchar(16)").IsRequired();
            builder.Property(model => model.QtdVendas).HasColumnType("int").IsRequired();
            builder.Property(model => model.Idade).HasColumnType("int");
            builder.Property(model => model.Email).HasColumnType("varchar(80)");
            builder.Property(model => model.Comissao).HasColumnType("money").IsRequired();
        }
    }
}
