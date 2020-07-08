using System;
using FluentValidation;
using ListaSupermercado.Application.Model;

namespace ListaSupermercado.API.Filters
{
    public class ProdutoValidator : AbstractValidator<RequestProduto>
    {
        public ProdutoValidator()
        {
            RuleFor(x => x.Nome).NotEmpty()
            .WithMessage("Preencha o nome do Produto");
        } 
    }
}
