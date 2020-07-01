using System;
using System.Collections.Generic;
using System.Text;

namespace ListaSupermercado.Domain.Entity
{
    public class ItemCarrinhoEntity
    {
        public int CarrinhoId { get; set; }
        public int ProdutoId { get; set; }

        public ProdutoEntity Produto { get; set; }

        public CarrinhoEntity Carrinho { get; set; }
    }
}
