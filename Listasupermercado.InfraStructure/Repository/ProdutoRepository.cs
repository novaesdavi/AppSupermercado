﻿using System;
using System.Threading.Tasks;
using Listasupermercado.Infrastructure.Context;
using ListaSupermercado.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Listasupermercado.Infrastructure.Repository
{
    public class ProdutoRepository : DbContext, IProdutoRepository
    {

        public ProdutoRepository(DbContextOptions<ProdutoRepository> options) : base(options)
        {

        }
        public DbSet<ProdutoEntity> Produtos { get; set; }

        public async Task<int> CriarProduto(ProdutoEntity produtoEntity)
        {
            Produtos.Add(produtoEntity);
            await base.SaveChangesAsync();
            return produtoEntity.Id;
        }

        public async Task<ProdutoEntity> ObterProduto(int idProduto)
        {
            var produtoEncontrado = await Produtos.FindAsync(idProduto);
            return produtoEncontrado;
        }
    }
}
