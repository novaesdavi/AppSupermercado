using AutoMapper;
using ListaSupermercado.Application.IRepository;
using ListaSupermercado.Application.Model;
using System.Threading.Tasks;

namespace ListaSupermercado.Application.UseCase
{
    public class ObterCarrinhoUseCase
    {

        private ICarrinhoRepository _repoCarrinho;
        private readonly IMapper _mapper;

        public ObterCarrinhoUseCase(ICarrinhoRepository repoCarrinho, IMapper mapper)
        {
            _repoCarrinho = repoCarrinho;
            _mapper = mapper;
        }
        public async Task<ResponseCarrinho> ExecuteAsync(int idProduto)
        {

            var carrinhoEntity = await _repoCarrinho.ObterCarrinho(idProduto);

            return _mapper.Map<ResponseCarrinho>(carrinhoEntity);
        }
    }

}


