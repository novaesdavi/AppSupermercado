using ListaSupermercado.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ListaSupermercado.Application.IRepository
{
    public interface IProdutoRepository
    {

        Task<ProdutoEntity> CriarProduto(ProdutoEntity produtoEntity);

        Task<ProdutoEntity> ObterProduto(int idProduto);

        Task<IEnumerable<ProdutoEntity>> ObterTodos();

    }
}
