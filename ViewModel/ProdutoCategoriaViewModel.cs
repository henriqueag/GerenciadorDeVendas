using GerenciadorEstoque.Models;
using System.Collections.Generic;

namespace GerenciadorEstoque.ViewModel
{
    public class ProdutoCategoriaViewModel
    {
        public Produto Produto { get; set; }
        public IEnumerable<Categoria> Categorias { get; set; }
    }
}
