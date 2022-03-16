namespace GerenciadorDeVendas.Models
{
    public abstract class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }

        protected Pessoa()
        {
        }

        protected Pessoa(int id, string nome, string cPF, int idade, string telefone, string email, Endereco endereco)
        {
            Id = id;
            Nome = nome;
            CPF = cPF;
            Idade = idade;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
        }
    }
}
