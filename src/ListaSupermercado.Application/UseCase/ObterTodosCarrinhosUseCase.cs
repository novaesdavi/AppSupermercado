using Listasupermercado.Infrastructure.Repository;
using ListaSupermercado.Application.Model;
using ListaSupermercado.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ListaSupermercado.Application.UseCase
{
    public class ObterTodosCarrinhosUseCase
    {

        private ICarrinhoRepository _repoCarrinho;
        public ObterTodosCarrinhosUseCase(ICarrinhoRepository repoCarrinho)
        {
            _repoCarrinho = repoCarrinho;
        }
        public async Task<ResponseTodosCarrinhos> ExecuteAsync()
        {

            var carrinhosEntity = await _repoCarrinho.ObterTodosCarrinhos();


            var listaCarrinhos = new List<ResponseCarrinho>();
            foreach (var item in carrinhosEntity)
            {
                ResponseCarrinho responseItem = new ResponseCarrinho();
                responseItem.Id = item.Id;
                responseItem.Nome = item.Nome;
                listaCarrinhos.Add(responseItem);
            }
            
            ResponseTodosCarrinhos responseTodos = new ResponseTodosCarrinhos();
            responseTodos.Carrinhos = new List<ResponseCarrinho>(listaCarrinhos);
            return responseTodos;
        }
    }

}


