using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Listasupermercado.Infrastructure.Context;
using ListaSupermercado.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Listasupermercado.Infrastructure.Repository
{
    public class CarrinhoRepository : ICarrinhoRepository
    {
        BaseContext _context;
        public CarrinhoRepository(BaseContext context)
        {
            _context = context;
        }


        public async Task<int> CriarCarrinho(CarrinhoEntity carrinho)
        {
            await _context.Carrinhos.AddAsync(carrinho);
            await _context.SaveChangesAsync();
            return carrinho.Id;
        }

        public async Task<int> IncluirItemCarrinho(ItemCarrinhoEntity itemCarrinho)
        {
            _context.ItensCarrinhos.Add(itemCarrinho);
            return await _context.SaveChangesAsync();
        }

        public async Task<CarrinhoEntity> ObterItensCarrinho(int idCarrinho)
        {
            var carrinho = await _context.Carrinhos.Where(w => w.Id == idCarrinho)
                                .Include(i => i.ItensCarrinhos)
                                .ThenInclude(p => p.Produto)
                                .FirstOrDefaultAsync();

                //AsNoTracking().FirstOrDefault(w => w.Id == idCarrinho)
                

            return carrinho;
        }

        public async Task<CarrinhoEntity> ObterCarrinho(int idCarrinho)
        {
            return await _context.Carrinhos.AsNoTracking().FirstOrDefaultAsync(w => w.Id == idCarrinho);

        }

        public async Task<IEnumerable<CarrinhoEntity>> ObterTodosCarrinhos()
        {
            return  await _context.Carrinhos.AsNoTracking().ToListAsync();
        }
    }
}
