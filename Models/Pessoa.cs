namespace GerenciadorDeVendas.Models
{
    public abstract class Pessoa
    {        
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int? Idade { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
