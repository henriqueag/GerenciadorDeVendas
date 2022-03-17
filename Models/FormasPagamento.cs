using GerenciadorDeVendas.Models.Enum;

namespace GerenciadorDeVendas.Models
{
    public class FormasPagamento
    {
        public int FormasPagamentoId { get; set; }
        public string Descricao { get; set; }
        public bool PermiteAcrescimo { get; set; }
        public bool PermiteDesconto { get; set; }
        public string TipoPagamento { get; set; }
    }
}
