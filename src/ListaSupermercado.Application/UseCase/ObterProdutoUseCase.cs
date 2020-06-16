using Listasupermercado.Infrastructure.Repository;
using ListaSupermercado.Application.Model;
using ListaSupermercado.Domain.Entity;
using System.Threading.Tasks;

namespace ListaSupermercado.Application.UseCase
{
    public class ObterProdutoUseCase
    {

        private IProdutoRepository _repoProduto;
        public ObterProdutoUseCase(IProdutoRepository repoProduto)
        {
            _repoProduto = repoProduto;
        }
        public async Task<ResponseProduto> ExecuteAsync(int idProduto)
        {

           var produtoEntity = await _repoProduto.ObterProduto(idProduto);
            

           return new ResponseProduto() { Id = produtoEntity.Id , Nome = produtoEntity.Nome};

        }
    }


}
