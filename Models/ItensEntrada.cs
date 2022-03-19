namespace GerenciadorEstoque.Models
{
    public class ItensEntrada
    {
        public int ItensEntradaId { get; set; }

        public int EntradaId { get; set; }
        public Entrada Entrada { get; set; }

        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        public double QtdProduto { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
