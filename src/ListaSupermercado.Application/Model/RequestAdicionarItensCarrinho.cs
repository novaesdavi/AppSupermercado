using System;
using System.Collections.Generic;
using System.Text;

namespace ListaSupermercado.Application.Model
{
    public class RequestAdicionarItensCarrinho
    {
        public int ProdutoId { get; set; }
        public int CarrinhoId { get; set; }
    }
}
