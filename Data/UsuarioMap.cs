using GerenciadorEstoque.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace GerenciadorEstoque.Data
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(model => model.Nome).HasColumnType("varchar(80)").IsRequired();
            builder.Property(model => model.CPF).HasColumnType("varchar(18)").IsRequired();
            builder.Property(model => model.Telefone).HasColumnType("varchar(16)").IsRequired();
            builder.Property(model => model.Email).HasColumnType("varchar(80)").IsRequired();
            builder.Property(model => model.Password).HasColumnType("varchar(110)").IsRequired();
            builder.Property(model => model.Username).HasColumnType("varchar(30)").IsRequired();
            builder.Property<DateTime>("DataCadastro").HasDefaultValueSql("getdate()");
            builder.Ignore(model => model.Endereco);
            builder.Ignore(model => model.EnderecoId);
        }
    }
}
