using ListaSupermercado.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;

namespace Listasupermercado.Infrastructure.Context
{
    public class BaseContext /*: DbContext*/
    {
        //private readonly IConfiguration config;
        //public BaseContext(IConfiguration config)
        //{
        //    this.config = config;
        //}
        //public BaseContext()
        //{

        //}
        //public DbSet<ProdutoEntity> Produtos { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        //    optionsBuilder.UseSqlServer(config["Data:ConnectionStrings:ConexaoApp"]);

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        //optionsBuilder.UseSqlServer("Password=teste123;Persist Security Info=True;User ID=sa;Initial Catalog=ListaSupermercadoDb;Data Source=DESKTOP-OI3NRP1");

    }
}
