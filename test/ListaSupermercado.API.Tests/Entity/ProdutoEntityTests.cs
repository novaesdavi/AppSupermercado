using ListaSupermercado.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ListaSupermercado.API.Tests.Entity
{
    
    public class ProdutoEntityTests
    {
        [Fact]
        public void PreencheEntidade()
        {
            int arrange = 0;
            ProdutoEntity produtoArrange = new ProdutoEntity("Davi");
            ProdutoEntity produtoAssert = new ProdutoEntity("Davi");

            Assert.Equal(produtoArrange.Nome, produtoAssert.Nome);
            Assert.Equal(arrange, produtoAssert.Id);

        }
    }
}
