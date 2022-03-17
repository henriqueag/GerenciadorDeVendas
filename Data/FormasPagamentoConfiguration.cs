using GerenciadorDeVendas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorDeVendas.Data
{
    public class FormasPagamentoConfiguration : IEntityTypeConfiguration<FormasPagamento>
    {
        public void Configure(EntityTypeBuilder<FormasPagamento> builder)
        {
            
        }
    }
}
