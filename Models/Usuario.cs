namespace GerenciadorEstoque.Models
{
    public class Usuario : Pessoa
    {
        public int UsuarioId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Ativo { get; set; }
    }
}
