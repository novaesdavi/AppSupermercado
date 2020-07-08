using Listasupermercado.Infrastructure.Context;
using Listasupermercado.Infrastructure.Repository;
using ListaSupermercado.Application.IRepository;
using ListaSupermercado.Application.UseCase;
using Microsoft.Extensions.DependencyInjection;

namespace Listasupermercado.Infrastructure.Configuration
{
    public static class Registry
    {
        public static void AddRegitry(this IServiceCollection services)
        {
            services.AddTransient<CriarProdutoUseCase, CriarProdutoUseCase>();
            services.AddTransient<ObterProdutoUseCase, ObterProdutoUseCase>();
            services.AddTransient<IProdutoRepository, ProdutoRepository>();

            services.AddTransient<CriarCarrinhoUseCase, CriarCarrinhoUseCase>();
            services.AddTransient<ObterCarrinhoUseCase, ObterCarrinhoUseCase>();
            services.AddTransient<ObterTodosCarrinhosUseCase, ObterTodosCarrinhosUseCase>();
            services.AddTransient<IncluirItemCarrinhoUseCase, IncluirItemCarrinhoUseCase>();
            services.AddTransient<ObterItensCarrinhoUseCase, ObterItensCarrinhoUseCase>();
            services.AddTransient<ICarrinhoRepository, CarrinhoRepository>();
            services.AddTransient<BaseContext, BaseContext>();

        }
    }

}
