using Listasupermercado.Infrastructure.Repository;
using ListaSupermercado.Application.Model;
using ListaSupermercado.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
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
