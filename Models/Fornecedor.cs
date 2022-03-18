namespace GerenciadorEstoque.Models
{
    public class Fornecedor
    {
        public int FornecedorId { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public Endereco Endereco { get; set; }
    }
}