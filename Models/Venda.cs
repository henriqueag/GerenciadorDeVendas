namespace GerenciadorDeVendas.Models
{
    public class Venda
    {
        public int VendaId { get; set; }
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public ItensDaVenda ItensDaVenda { get; set; }
        public FormasPagamento FormaDePagamento { get; set; }
        public decimal Desconto { get; set; }
        public decimal Acrescimo { get; set; }
        public decimal TotalGeral { get; set; }
    }
}