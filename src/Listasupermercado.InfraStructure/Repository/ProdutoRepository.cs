using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Listasupermercado.Infrastructure.Context;
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

        public async Task<int> CriarProduto(ProdutoEntity produtoEntity)
        {
            _context.Produtos.Add(produtoEntity);
            await _context.SaveChangesAsync();
            return produtoEntity.Id;
        }

        public async Task<ProdutoEntity> ObterProduto(int idProduto)
        {
            return await _context.Produtos.AsNoTracking().FirstOrDefaultAsync(w => w.Id == idProduto);
        }

        public async Task<IEnumerable<ProdutoEntity>> ObterTodos()
        {
            return await _context.Produtos.ToListAsync();
        }
    }
}
