using AutoMapper;
using ListaSupermercado.Application.IRepository;
using ListaSupermercado.Application.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ListaSupermercado.Application.UseCase
{
    public class ObterTodosCarrinhosUseCase
    {

        private ICarrinhoRepository _repoCarrinho;
        private readonly IMapper _mapper;
        public ObterTodosCarrinhosUseCase(ICarrinhoRepository repoCarrinho, IMapper mapper)
        {
            _repoCarrinho = repoCarrinho;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ResponseCarrinho>> ExecuteAsync()
        {

            var carrinhosEntity = await _repoCarrinho.ObterTodosCarrinhos();
            return _mapper.Map<IEnumerable<ResponseCarrinho>>(carrinhosEntity);
        }
    }

}


