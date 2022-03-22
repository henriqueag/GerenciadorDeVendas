using Newtonsoft.Json;
using System.Collections.Generic;

namespace GerenciadorEstoque.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        [JsonIgnore]
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
