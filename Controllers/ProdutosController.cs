using GerenciadorEstoque.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GerenciadorEstoque.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IProdutoService _produtoService;
        private readonly ICategoriaService _categoriaService;

        public ProdutosController(IProdutoService produtoService, ICategoriaService categoriaService)
        {
            _produtoService = produtoService;
            _categoriaService = categoriaService;
        }

        public async Task<IActionResult> Cadastrar()
        {            
            return View(ViewBag["categorias"]);
        }
    }
}
