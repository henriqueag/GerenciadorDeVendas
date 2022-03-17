using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeVendas.Models
{
    public class ItensDaVenda
    {
        public int VendaId { get; set; }
        public Produto Produtos { get; set; }
        public double QtdPorProduto { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
