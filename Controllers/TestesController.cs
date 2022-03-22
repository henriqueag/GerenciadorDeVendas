using GerenciadorEstoque.Models;
using GerenciadorEstoque.Service.Interface;
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var produto = await _service.GetById(id);
                return Ok(produto);
            }
            catch (System.Exception ex)
            {
                return NotFound(ex.Message);
            }
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

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Produto produto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _service.Update(produto);
            return Ok(produto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _service.Delete(id);
                return Ok("Produto excluído.");
            }
            catch (System.Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }

}
