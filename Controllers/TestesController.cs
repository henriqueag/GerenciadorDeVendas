using GerenciadorEstoque.Models;
using GerenciadorEstoque.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GerenciadorEstoque.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class TestesController : Controller
    {
        private readonly IProdutoService _service;

        public TestesController(IProdutoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var produtos = await _service.GetAll();
            return Ok(produtos);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody]Produto produto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _service.Add(produto);
            return Ok(produto);
        }
    }

}
