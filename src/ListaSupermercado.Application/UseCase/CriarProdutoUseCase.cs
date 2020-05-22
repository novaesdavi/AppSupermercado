using Listasupermercado.Infrastructure.Repository;
using ListaSupermercado.Application.Model;
using ListaSupermercado.Domain.Entity;
using System.Threading.Tasks;

namespace ListaSupermercado.Application.UseCase
{
    public class CriarProdutoUseCase
    {

        private IProdutoRepository _repoProduto;
        public CriarProdutoUseCase(IProdutoRepository repoProduto)
        {
            _repoProduto = repoProduto;
        }
        public async Task<bool> ExecuteAsync(RequestProduto produto)
        {
            ProdutoEntity produtoEntity = new ProdutoEntity(produto.Nome);

            await _repoProduto.CriarProduto(produtoEntity);

            return false;

        }
    }


}
