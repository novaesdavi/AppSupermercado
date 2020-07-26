using AutoMapper;
using ListaSupermercado.Application.IRepository;
using ListaSupermercado.Application.Model;
using ListaSupermercado.Domain.Entity;
using System.Threading.Tasks;

namespace ListaSupermercado.Application.UseCase
{
    public class CriarCarrinhoUseCase
    {
        private ICarrinhoRepository carrinhoRepo;
        private readonly IMapper mapper;
        public CriarCarrinhoUseCase(ICarrinhoRepository carrinhoRepo, IMapper mapper)
        {
            this.carrinhoRepo = carrinhoRepo;
            this.mapper = mapper;
        }

        public async Task<ResponsePostCarrinho> ExecuteAsync(RequestCarrinho request)
        {
            CarrinhoEntity carrinho = new CarrinhoEntity(request.Nome);
            await carrinhoRepo.CriarCarrinho(carrinho);

            //mapper.Map<ResponsePostCarrinho>(carrinho);

            return mapper.Map<ResponsePostCarrinho>(carrinho);
        }
    }
}
