using System;
using System.Collections.Generic;

namespace GerenciadorEstoque.Models
{
    public class Saida
    {
        public int SaidaId { get; set; }
        public string NroNota { get; set; }
        public int SolicitanteId { get; set; }
        public Solicitante Solicitante { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataSaida { get; set; }
        public decimal TotalSaida { get; set; }
        public decimal Acrescimo { get; set; }
        public decimal Desconto { get; set; }
        public int QtdProdutos { get; set; }
        public int QtdItens { get; set; }
        public string InformacoesAdicionais { get; set; }

        public ICollection<ItensSaida> ItensSaida { get; set; }
    }
}
