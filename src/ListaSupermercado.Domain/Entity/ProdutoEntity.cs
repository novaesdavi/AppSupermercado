using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ListaSupermercado.Domain.Entity
{
    public class ProdutoEntity : Notifiable
    {
        public ProdutoEntity(string nome)
        {

            Nome = nome;
        }
        public ProdutoEntity()
        {

        }
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public IEnumerable<ItemCarrinhoEntity> ItensCarrinhos { get; set; }
    }
}
