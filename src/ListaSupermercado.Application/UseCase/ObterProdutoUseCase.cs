using AutoMapper;
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
        private readonly IMapper _mapper;
        public ObterProdutoUseCase(IProdutoRepository repoProduto, IMapper mapper)
        {
            _repoProduto = repoProduto;
            _mapper = mapper;
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

            return _mapper.Map<IEnumerable<ResponseProduto>>(produtoEntities);
        }
    }


}
