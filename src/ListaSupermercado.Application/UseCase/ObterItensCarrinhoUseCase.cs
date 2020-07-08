using ListaSupermercado.Application.IRepository;
using ListaSupermercado.Application.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ListaSupermercado.Application.UseCase
{
    public class ObterItensCarrinhoUseCase
    {

        private ICarrinhoRepository _repoCarrinho;
        public ObterItensCarrinhoUseCase(ICarrinhoRepository repoCarrinho)
        {
            _repoCarrinho = repoCarrinho;
        }
        public async Task<ResponseItensCarrinho> ExecuteAsync(int idCarrinho)
        {

            var carrinhoEntity = await _repoCarrinho.ObterItensCarrinho(idCarrinho);

            ResponseItensCarrinho responseItens = new ResponseItensCarrinho();
            responseItens.Id = carrinhoEntity.Id;
            responseItens.Nome = carrinhoEntity.Nome;
            var produtos = new List<ResponseItensCarrinhoProduto>();

            foreach (var item in carrinhoEntity.ItensCarrinhos)
            {
                var produto = new ResponseItensCarrinhoProduto();
                produto.Id = item.Produto.Id;
                produto.Nome = item.Produto.Nome;
                produtos.Add(produto);
            }

            responseItens.Produtos = produtos;

            return responseItens;
        }
    }
}
