using System;
using System.Collections.Generic;
using System.Text;

namespace ListaSupermercado.Application.Model
{
    public class ResponseTodosCarrinhos
    {
        public IEnumerable<ResponseCarrinho> Carrinhos { get; set; }
    }
}
