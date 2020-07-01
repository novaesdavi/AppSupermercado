using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListaSupermercado.Application.Model;
using ListaSupermercado.Application.UseCase;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ListaSupermercado.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CarrinhoController : ControllerBase
    {

        private readonly ILogger<CarrinhoController> _logger;
        private readonly CriarCarrinhoUseCase _criarCarrinhoUseCase;
        private readonly ObterCarrinhoUseCase _obterCarrinhoUseCase;
        private readonly ObterTodosCarrinhosUseCase _obterTodosCarrinhosUseCase;

        public CarrinhoController(ILogger<CarrinhoController> logger, 
            CriarCarrinhoUseCase criarCarrinhoUseCase, 
            ObterCarrinhoUseCase obterCarrinhoUseCase,
            ObterTodosCarrinhosUseCase obterTodosCarrinhosUseCase
            )
        {
            _logger = logger;
            _criarCarrinhoUseCase = criarCarrinhoUseCase;
            _obterCarrinhoUseCase = obterCarrinhoUseCase;
            _obterTodosCarrinhosUseCase = obterTodosCarrinhosUseCase;

        }


        // GET: api/Carrinho/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await _obterCarrinhoUseCase.ExecuteAsync(id);
            return Ok(response);
        }

        [HttpGet(Name = "GetTodos")]
        public async Task<IActionResult> GetTodos()
        {
            var response = await _obterTodosCarrinhosUseCase.ExecuteAsync();
            return Ok(response);
        }

        // POST: api/Carrinho
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RequestCarrinho value)
        {
            var response = await _criarCarrinhoUseCase.ExecuteAsync(value);

            return Created("/carrinhos", response);
        }
    }
}
