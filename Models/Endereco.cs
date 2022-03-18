namespace GerenciadorEstoque.Models
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string DDD { get; set; }
        public int Numero { get; set; }

        public int ClienteId { get; set; }
        public virtual Usuario Cliente { get; set; }
    }
}