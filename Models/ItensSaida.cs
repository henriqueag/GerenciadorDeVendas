namespace GerenciadorEstoque.Models
{
    public class ItensSaida
    {
        public int ItensSaidaId { get; set; }

        public int SaidaId { get; set; }
        public Saida Saida { get; set; }

        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        public double QtdProduto { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
