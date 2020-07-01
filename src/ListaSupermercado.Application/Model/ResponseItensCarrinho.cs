using System;
using System.Collections.Generic;
using System.Text;

namespace ListaSupermercado.Application.Model
{
    public class ResponseItensCarrinho
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<ResponseItensCarrinhoProduto> Produtos { get; set; }

    }

    public class ResponseItensCarrinhoProduto {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
