using AutoMapper;
using ListaSupermercado.Application.Model;
using ListaSupermercado.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaSupermercado.Application.Mapper
{
    public class MapperGeral : Profile
    {
        public MapperGeral()
        {
            CreateMap<CarrinhoEntity, ResponsePostCarrinho>();
            CreateMap<CarrinhoEntity, ResponseCarrinho>();
            CreateMap<ProdutoEntity, ResponseProduto>();

            CreateMap<CarrinhoEntity, ResponseItensCarrinho>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(origem => origem.Id))
               .ForMember(dest => dest.Nome, opt => opt.MapFrom(origem => origem.Nome))
               .ForPath(dest => dest.Produtos, opt => opt.MapFrom(origem => origem.ItensCarrinhos));


            CreateMap<CarrinhoEntity, ResponseItensCarrinho>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(origem => origem.Id))
               .ForMember(dest => dest.Nome, opt => opt.MapFrom(origem => origem.Nome))
               .ForPath(dest => dest.Produtos, opt => opt.MapFrom(origem => origem.ItensCarrinhos));

            CreateMap<ItemCarrinhoEntity, ResponseItensCarrinhoProduto>()
                .ForPath(dest => dest.Id, opt => opt.MapFrom(origem => origem.Produto.Id))
                .ForPath(dest => dest.Nome, opt => opt.MapFrom(origem => origem.Produto.Nome));


            //CreateMap<IEnumerable<ProdutoEntity>, IEnumerable<ResponseProduto>>()
            //    .ForMember(dest => dest, opt => opt.MapFrom(origem => origem.Select(s => s.a)));
        }
    }
}
