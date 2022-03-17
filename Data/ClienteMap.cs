using GerenciadorDeVendas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorDeVendas.Data
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("cliente");
            builder.Property(model => model.Nome).HasColumnType("varchar(80)").IsRequired();
            builder.Property(model => model.CPF).HasColumnType("varchar(15)").IsRequired();
            builder.Property(model => model.Telefone).HasColumnType("varchar(16)").IsRequired();
            builder.Property(model => model.QtdCompras).HasColumnType("int").IsRequired();
            builder.Property(model => model.Idade).HasColumnType("int");
            builder.Property(model => model.Email).HasColumnType("varchar(80)");
            builder.Property(model => model.DataNascimento).HasColumnType("datetime");
        }
    }
}
