using ListaSupermercado.Application.IRepository;
using ListaSupermercado.Application.Model;
using ListaSupermercado.Domain.Entity;
using System.Threading.Tasks;

namespace ListaSupermercado.Application.UseCase
{
    public class CriarCarrinhoUseCase
    {
        private ICarrinhoRepository carrinhoRepo;
        
        public CriarCarrinhoUseCase(ICarrinhoRepository carrinhoRepo)
        {
            this.carrinhoRepo = carrinhoRepo;
           
        }

        public async Task<ResponsePostCarrinho> ExecuteAsync(RequestCarrinho request)
        {
            ResponsePostCarrinho response = new ResponsePostCarrinho();
            CarrinhoEntity carrinho = new CarrinhoEntity(request.Nome);
            response.Id =  await carrinhoRepo.CriarCarrinho(carrinho);
            response.Nome = carrinho.Nome;
            return response;
        }
    }
}
