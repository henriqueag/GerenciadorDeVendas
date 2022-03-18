using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorEstoque.Models
{
    public class Usuario : Pessoa
    {
        public int UsuarioId { get; set; }
        public bool Ativo { get; set; }
        public virtual Endereco Endereco { get; set; }
    }
}
