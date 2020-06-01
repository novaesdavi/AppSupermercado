using System;

namespace ListaSupermercado.Application.Model
{
    public class RequestProduto
    {

        public RequestProduto()
        {

        }
        public RequestProduto(string Nome)
        {
           this.Nome = Nome;
        }
        public string Nome { get; set; }
    }
}
