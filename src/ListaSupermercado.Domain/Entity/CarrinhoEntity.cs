using System;
using System.Collections.Generic;
using System.Text;

namespace ListaSupermercado.Domain.Entity
{
    public class CarrinhoEntity
    {
        public CarrinhoEntity(string nome)
        {
            Nome = nome;
        }
        public CarrinhoEntity()
        {

        }
        public int Id { get; set; }
        public string Nome { get; set; }

        public IEnumerable<ItemCarrinhoEntity> ItensCarrinhos { get; set; }
    }
}
