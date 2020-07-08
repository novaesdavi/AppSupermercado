using ListaSupermercado.Application.IRepository;
using ListaSupermercado.Application.Model;
using ListaSupermercado.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ListaSupermercado.Application.UseCase
{
    public class ObterProdutoUseCase
    {

        private IProdutoRepository _repoProduto;
        public ObterProdutoUseCase(IProdutoRepository repoProduto)
        {
            _repoProduto = repoProduto;
        }
        public async Task<IEnumerable<ResponseProduto>> ExecuteAsync(int idProduto = 0)
        {

            var produtoEntities = new List<ProdutoEntity>();
            if (idProduto == 0)
            {
                produtoEntities.AddRange(await _repoProduto.ObterTodos());
            }
            else {
                produtoEntities.Add(await _repoProduto.ObterProduto(idProduto));
            }

            var responseProdutos = new List<ResponseProduto>();

            foreach (var item in produtoEntities)
            {
                responseProdutos.Add(new ResponseProduto() { Id = item.Id, Nome = item.Nome });
            }

            return responseProdutos;

        }
    }


}
