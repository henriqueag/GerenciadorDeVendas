using System.Collections.Generic;

namespace GerenciadorDeVendas.Models
{
    public class ItensDaVenda
    {
        public int VendaId { get; set; }
        public virtual Venda Venda { get; set; }

        public int ProdutoId { get; set; }
        public virtual Produto Produtos { get; set; }

        public double QtdPorProduto { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
