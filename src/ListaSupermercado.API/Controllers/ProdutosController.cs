using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListaSupermercado.Application.Model;
using ListaSupermercado.Application.UseCase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ListaSupermercado.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]

    public class ProdutosController : ControllerBase
    {
        private readonly ILogger<ProdutosController> _logger;
        private readonly CriarProdutoUseCase _criarProdutoUseCase;
        private readonly ObterProdutoUseCase _obterProdutoUseCase;

        public ProdutosController(ILogger<ProdutosController> logger, CriarProdutoUseCase criarProdutoUseCase, ObterProdutoUseCase obterProdutoUseCase)
        {
            _logger = logger;
            _criarProdutoUseCase = criarProdutoUseCase;
            _obterProdutoUseCase = obterProdutoUseCase;
        }

        [HttpGet("{id_produto}")]
        public async Task<IActionResult> Get([FromRoute(Name = "id_produto")] int id)
        {
            var item = await _obterProdutoUseCase.ExecuteAsync(id);
            return Ok(item);
        }

        public async Task<IActionResult> GetTodos()
        {
            var item = await _obterProdutoUseCase.ExecuteAsync();
            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RequestProduto produto)
        {
            var produtoCriado = await _criarProdutoUseCase.ExecuteAsync(produto);

            return Created("/produtos", produtoCriado);

        }
    }
}