using GerenciadorDeVendas.Models.Enum;

namespace GerenciadorDeVendas.Models
{
    public class FormasPagamento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool TemAcrescimo { get; set; }
        public decimal PercentualAcrescimo { get; set; }
        public TipoPagamento TipoPagamento { get; set; }
    }
}
