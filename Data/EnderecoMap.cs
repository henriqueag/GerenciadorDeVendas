using GerenciadorDeVendas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorDeVendas.Data
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("endereco");
            builder.Property(model => model.Cep).HasColumnType("varchar(10)").IsRequired();
            builder.Property(model => model.Logradouro).HasColumnType("varchar(60)").IsRequired();
            builder.Property(model => model.Complemento).HasColumnType("varchar(30)");
            builder.Property(model => model.Bairro).HasColumnType("varchar(50)").IsRequired();
            builder.Property(model => model.Cidade).HasColumnType("varchar(50)").IsRequired();
            builder.Property(model => model.Uf).HasColumnType("char(2)").IsRequired();
            builder.Property(model => model.DDD).HasColumnType("varchar(3)");
        }
    }
}
