using ListaSupermercado.Application.Model;
using ListaSupermercado.Domain.Entity;
using System.Threading.Tasks;
using ListaSupermercado.Application.IRepository;
using ListaSupermercado.Application.Filters;
using AutoMapper;

namespace ListaSupermercado.Application.UseCase
{
    public class CriarProdutoUseCase
    {
        private IProdutoRepository _repoProduto;
        INotificationContext _fluntcontext;
        private readonly IMapper _mapper;
        public CriarProdutoUseCase(IProdutoRepository repoProduto, INotificationContext fluntcontext, IMapper mapper)
        {
            _repoProduto = repoProduto;
            _fluntcontext = fluntcontext;
            _mapper = mapper;
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

            return _mapper.Map<ResponseProduto>(produtoIncluido);
        }
    }


}
