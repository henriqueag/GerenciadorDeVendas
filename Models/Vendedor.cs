﻿namespace GerenciadorDeVendas.Models
{
    public class Vendedor : Pessoa
    {
        public int VendedorId { get; set; }
        public decimal Comissao { get; set; }
        public int QtdVendas { get; set; }
    }
}
