using FluentValidation;
using Pedidos.Application.src.Dtos.DtoEntities;

namespace Pedidos.Application.src.Validators
{
    public class EstadoValidator : ValidatorBase<EstadoDto>
    {
        public EstadoValidator()
        {
            RuleFor(x => x.Uf).NotNull().NotEmpty().WithMessage("O campo 'UF' deve ser informado");
            RuleFor(x => x.Descricao).NotNull().NotEmpty().WithMessage("O campo 'Descrição' deve ser informado");
        }
    }
}