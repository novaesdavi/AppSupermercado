using System;
using System.Collections;
using System.Collections.Generic;

namespace ListaSupermercado.Application.Model
{
    public class ResponseTodosProdutos
    {
        public IEnumerable<ResponseProduto> Produtos { get; set; }
    }

    public class ResponseProduto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
