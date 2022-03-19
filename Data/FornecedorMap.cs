using GerenciadorEstoque.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorEstoque.Data
{
    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.Property(model => model.Nome).HasColumnType("varchar(100)").IsRequired();
            builder.Property(model => model.CNPJ).HasColumnType("varchar(20)").IsRequired();
        }
    }
}
