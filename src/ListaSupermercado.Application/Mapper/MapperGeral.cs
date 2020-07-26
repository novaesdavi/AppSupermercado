using AutoMapper;
using ListaSupermercado.Application.Model;
using ListaSupermercado.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListaSupermercado.Application.Mapper
{
    public class MapperGeral : Profile
    {
        public MapperGeral()
        {
            CreateMap<CarrinhoEntity, ResponsePostCarrinho>();
        }
    }
}
