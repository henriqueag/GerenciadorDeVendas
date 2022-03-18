using System;

namespace GerenciadorEstoque.Models
{
    public class Entrada
    {
        public int EntradaId { get; set; }
        public string NroNota { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataEntrada { get; set; }
        public decimal TotalEntrada { get; set; }
        public decimal Acrescimo { get; set; }
        public decimal Desconto { get; set; }
        public int QtdProdutos { get; set; }
        public int QtdItens { get; set; }
        public string InformacoesAdicionais { get; set; }
    }
}
