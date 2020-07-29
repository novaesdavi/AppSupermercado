using AutoMapper;
using ListaSupermercado.Application.IRepository;
using ListaSupermercado.Application.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ListaSupermercado.Application.UseCase
{
    public class ObterItensCarrinhoUseCase
    {

        private ICarrinhoRepository _repoCarrinho;
        private readonly IMapper _mapper;
        public ObterItensCarrinhoUseCase(ICarrinhoRepository repoCarrinho, IMapper mapper)
        {
            _repoCarrinho = repoCarrinho;
            _mapper = mapper;
        }
        public async Task<ResponseItensCarrinho> ExecuteAsync(int idCarrinho)
        {

            var carrinhoEntity = await _repoCarrinho.ObterItensCarrinho(idCarrinho);


            return _mapper.Map<ResponseItensCarrinho>(carrinhoEntity);

            //ResponseItensCarrinho responseItens = new ResponseItensCarrinho();
            //responseItens.Id = carrinhoEntity.Id;
            //responseItens.Nome = carrinhoEntity.Nome;
            //var produtos = new List<ResponseItensCarrinhoProduto>();

            //foreach (var item in carrinhoEntity.ItensCarrinhos)
            //{
            //    var produto = new ResponseItensCarrinhoProduto();
            //    produto.Id = item.Produto.Id;
            //    produto.Nome = item.Produto.Nome;
            //    produtos.Add(produto);
            //}

            //responseItens.Produtos = produtos;



            //return responseItens;
        }
    }
}
