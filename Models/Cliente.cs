using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeVendas.Models
{
    public class Cliente : Pessoa
    {
        public int ClienteId { get; set; }
        public DateTime? DataNascimento { get; set; }
        public int QtdCompras { get; set; }
        public Endereco Endereco { get; set; }
    }
}
