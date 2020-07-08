using ListaSupermercado.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ListaSupermercado.Application.IRepository
{
    public interface ICarrinhoRepository
    {
        Task<int> CriarCarrinho(CarrinhoEntity carrinho);
        Task<CarrinhoEntity> ObterCarrinho(int idCarrinho);
        Task<IEnumerable<CarrinhoEntity>> ObterTodosCarrinhos();
        Task<int> IncluirItemCarrinho(ItemCarrinhoEntity itemCarrinho);
        Task<CarrinhoEntity> ObterItensCarrinho(int idCarrinho);
    }
}
