﻿namespace GerenciadorEstoque.Models
{
    public abstract class Pessoa
    {        
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }        
    }
}
