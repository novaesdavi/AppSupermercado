using ListaSupermercado.Application.IRepository;
using ListaSupermercado.Application.Model;
using ListaSupermercado.Domain.Entity;
using System.Threading.Tasks;

namespace ListaSupermercado.Application.UseCase
{
    public class IncluirItemCarrinhoUseCase
    {
        private ICarrinhoRepository carrinhoRepo;

        public IncluirItemCarrinhoUseCase(ICarrinhoRepository carrinhoRepo)
        {
            this.carrinhoRepo = carrinhoRepo;
        }

        public async Task ExecuteAsync(RequestAdicionarItensCarrinho request)
        {

            ItemCarrinhoEntity itemEntity = new ItemCarrinhoEntity();
            itemEntity.CarrinhoId = request.CarrinhoId;
            itemEntity.ProdutoId = request.ProdutoId;

            await carrinhoRepo.IncluirItemCarrinho(itemEntity);
        }
    }
}
