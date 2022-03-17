using GerenciadorDeVendas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorDeVendas.Data
{
    public class ItensDaVendaConfiguration : IEntityTypeConfiguration<ItensDaVenda>
    {
        public void Configure(EntityTypeBuilder<ItensDaVenda> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
