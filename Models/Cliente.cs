using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeVendas.Models
{
    public class Cliente : Pessoa
    {
        public DateTime DataNascimento { get; set; }
        public int QtdCompras { get; set; }        
    }
}
