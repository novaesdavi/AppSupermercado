using ListaSupermercado.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Listasupermercado.Infrastructure.Repository
{
    public interface IProdutoRepository
    {

        Task<int> CriarProduto(ProdutoEntity produtoEntity);

        Task<ProdutoEntity> ObterProduto(int idProduto);

        Task<IEnumerable<ProdutoEntity>> ObterTodos();

    }
}
