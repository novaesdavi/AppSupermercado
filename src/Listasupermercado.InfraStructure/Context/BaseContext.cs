using ListaSupermercado.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using Listasupermercado.Infrastructure.Repository;

namespace Listasupermercado.Infrastructure.Context
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options) { }
        public DbSet<CarrinhoEntity> Carrinhos { get; set; }
        public DbSet<ProdutoEntity> Produtos { get; set; }
        public DbSet<ItemCarrinhoEntity> ItensCarrinhos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemCarrinhoEntity>(entity => {
                entity.HasKey(e => new { e.CarrinhoId, e.ProdutoId });
            });
        }
    }
}
