using ListaSupermercado.Application.Model;
using ListaSupermercado.Domain.Entity;
using System.Threading.Tasks;
using ListaSupermercado.Application.IRepository;
using ListaSupermercado.Application.Filters;

namespace ListaSupermercado.Application.UseCase
{
    public class CriarProdutoUseCase
    {

        private IProdutoRepository _repoProduto;
        INotificationContext _fluntcontext;
        public CriarProdutoUseCase(IProdutoRepository repoProduto, INotificationContext fluntcontext)
        {
            _repoProduto = repoProduto;
            _fluntcontext = fluntcontext;
        }
        public async Task<ResponseProduto> ExecuteAsync(RequestProduto produto)
        {
            ProdutoEntity produtoEntity = new ProdutoEntity(produto.Nome);

            var produtoIncluido = await _repoProduto.CriarProduto(produtoEntity);

            if (produtoIncluido.Id == 0)
            {
                _fluntcontext.AddNotification(new Flunt.Notifications.Notification("nome_produto", "produto já existe"));
                return null;
            }

            return new ResponseProduto() { Id = produtoIncluido.Id, Nome = produtoIncluido.Nome };

        }
    }


}
