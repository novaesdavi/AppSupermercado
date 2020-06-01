using System;
using System.Collections.Generic;
using System.Text;

namespace ListaSupermercado.Domain.Entity
{
    public class ProdutoEntity
    {
        public ProdutoEntity(string nome)
        {
            Nome = nome;
        }
        public ProdutoEntity()
        {

        }
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
