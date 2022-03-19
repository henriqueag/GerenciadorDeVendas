namespace GerenciadorEstoque.Models
{
    public class Usuario : Pessoa
    {
        public int UsuarioId { get; set; }
        public bool Ativo { get; set; }
    }
}
