using System;
using Newtonsoft.Json;

namespace GerenciadorEstoque.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string CodBarras { get; set; }
        public string Descricao { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal PrecoVenda { get; set; }
        public double Estoque { get; set; }
        public string UniMedida { get; set; }
        public bool Ativo { get; set; }
        [JsonIgnore]
        public DateTime DataCadastro { get; set; }
        [JsonIgnore]
        public DateTime UltimaAlteracao { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
