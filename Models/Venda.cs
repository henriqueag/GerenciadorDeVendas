using GerenciadorDeVendas.Models.Enum;
using System;
using System.Collections.Generic;

namespace GerenciadorDeVendas.Models
{
    public class Venda
    {
        public int VendaId { get; set; }

        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

        public int VendedorId { get; set; }
        public virtual Vendedor Vendedor { get; set; }

        public virtual ICollection<ItensDaVenda> ItensDaVenda { get; set; }

        public int FormasPagamentoId { get; set; }
        public virtual FormasPagamento FormasPagamento { get; set; }

        public TipoPagamento TipoPagamento { get; set; }
        public DateTime DataLancamento { get; set; }
        public decimal Desconto { get; set; }
        public decimal Acrescimo { get; set; }
        public decimal TotalGeral { get; set; }
    }
}