using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Listasupermercado.Infrastructure.Context;
using ListaSupermercado.Application.IRepository;
using ListaSupermercado.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Listasupermercado.Infrastructure.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        BaseContext _context;
        public ProdutoRepository(BaseContext context)
        {
            _context = context;
        }

        public async Task<ProdutoEntity> CriarProduto(ProdutoEntity produtoEntity)
        {
            if (_context.Produtos.Any(a => a.Nome == produtoEntity.Nome))
            {
                return produtoEntity;
            }

            _context.Produtos.Add(produtoEntity);
            await _context.SaveChangesAsync();
            
            return produtoEntity;

        }

        public async Task<ProdutoEntity> ObterProduto(int idProduto)
        {
            return await _context.Produtos.FirstOrDefaultAsync(w => w.Id == idProduto);
        }

        public async Task<IEnumerable<ProdutoEntity>> ObterTodos()
        {
            return await _context.Produtos.ToListAsync();
        }
    }
}
