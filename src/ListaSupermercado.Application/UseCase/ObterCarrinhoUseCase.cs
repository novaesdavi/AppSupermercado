using ListaSupermercado.Application.IRepository;
using ListaSupermercado.Application.Model;
using System.Threading.Tasks;

namespace ListaSupermercado.Application.UseCase
{
    public class ObterCarrinhoUseCase
    {

        private ICarrinhoRepository _repoCarrinho;
        public ObterCarrinhoUseCase(ICarrinhoRepository repoCarrinho)
        {
            _repoCarrinho = repoCarrinho;
        }
        public async Task<ResponseCarrinho> ExecuteAsync(int idProduto)
        {

            var carrinhoEntity = await _repoCarrinho.ObterCarrinho(idProduto);

            ResponseCarrinho responseItem = new ResponseCarrinho();
            responseItem.Id = carrinhoEntity.Id;
            responseItem.Nome = carrinhoEntity.Nome;

            return responseItem;
        }
    }

}


