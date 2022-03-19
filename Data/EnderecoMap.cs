using GerenciadorEstoque.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorEstoque.Data
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.Property(model => model.Cep).HasColumnType("varchar(10)").IsRequired();
            builder.Property(model => model.Logradouro).HasColumnType("varchar(60)").IsRequired();
            builder.Property(model => model.Complemento).HasColumnType("varchar(30)");
            builder.Property(model => model.Bairro).HasColumnType("varchar(40)").IsRequired();
            builder.Property(model => model.Cidade).HasColumnType("varchar(60)").IsRequired();
            builder.Property(model => model.Uf).HasColumnType("char(2)").IsRequired();
        }
    }
}
