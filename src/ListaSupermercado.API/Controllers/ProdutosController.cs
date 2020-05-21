using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListaSupermercado.Application.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ListaSupermercado.API.Controllers {
    [ApiController]
    [Route ("api/v1/[controller]")]

    public class ProdutosController : ControllerBase {
        private readonly ILogger<ProdutosController> _logger;

        public ProdutosController (ILogger<ProdutosController> logger) {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ResponseProduto> Get () {
            return new ResponseProduto ();
        }
    }
}