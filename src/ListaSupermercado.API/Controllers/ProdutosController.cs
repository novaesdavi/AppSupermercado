using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListaSupermercado.Application.Model;
using ListaSupermercado.Application.UseCase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ListaSupermercado.API.Controllers {
    [ApiController]
    [Route ("api/v1/[controller]")]

    public class ProdutosController : ControllerBase {
        private readonly ILogger<ProdutosController> _logger;
        private readonly CriarProdutoUseCase _criarProdutoUseCase;

        public ProdutosController (ILogger<ProdutosController> logger, CriarProdutoUseCase criarProdutoUseCase) {
            _logger = logger;
            _criarProdutoUseCase = criarProdutoUseCase;
        }

        [HttpGet]
        public async Task<ResponseProduto> Get () {
            return new ResponseProduto ();
        }

        [HttpPost]
        public async Task<ResponseProduto> Post([FromBody] RequestProduto produto)
        {
            //await _criarProdutoUseCase.ExecuteAsync(produto);
            return new ResponseProduto();
        }
    }
}