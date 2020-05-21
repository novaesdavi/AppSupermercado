using System;
using System.Threading.Tasks;
using ListaSupermercado.API;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace ListaSupermercado.Integracao.Tests {
    public class ProdutosControllerTests : IClassFixture<WebApplicationFactory<ListaSupermercado.API.Startup>> {

        private readonly WebApplicationFactory<ListaSupermercado.API.Startup> _factory;

        public ProdutosControllerTests (WebApplicationFactory<ListaSupermercado.API.Startup> factory) {
            _factory = factory;
        }

        [Theory]
        [InlineData ("/app/v1/produtos")]
        public async Task DeveretornarNenhumproduto (string url) {
            var client = _factory.CreateClient ();

            var response = await client.GetAsync (url);

            response.EnsureSuccessStatusCode (); // Status Code 200-299

            return;
        }
    }
}