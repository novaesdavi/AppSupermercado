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
    [Route("api/v1/Carrinho")]
    [ApiController]
    public class ItensCarrinhoController : ControllerBase
    {
        private readonly ILogger<ItensCarrinhoController> _logger;
        private readonly IncluirItemCarrinhoUseCase _itemCarrinhoUseCase;
        private readonly ObterItensCarrinhoUseCase _obterItensCarrinhoUseCase;
        public ItensCarrinhoController(ILogger<ItensCarrinhoController> logger,
            IncluirItemCarrinhoUseCase itemCarrinhoUseCase,
            ObterItensCarrinhoUseCase obterItensCarrinhoUseCase)
        {
            _logger = logger;
            _itemCarrinhoUseCase = itemCarrinhoUseCase;
            _obterItensCarrinhoUseCase = obterItensCarrinhoUseCase;
        }


        [HttpGet("{idCarrinho}/[controller]", Name = "GetItensCarrinho")]
        public async Task<IActionResult> GetItensCarrinho(int idCarrinho)
        {
            var carrinhoEntity = await _obterItensCarrinhoUseCase.ExecuteAsync(idCarrinho);
            return Ok(carrinhoEntity);
        }


        [HttpPost("[controller]")]
        public async Task<IActionResult> Post([FromBody] RequestAdicionarItensCarrinho value)
        {
            await _itemCarrinhoUseCase.ExecuteAsync(value);
            return Created("","Item incluído com Sucesso");
        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
