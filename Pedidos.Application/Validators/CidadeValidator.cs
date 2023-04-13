using FluentValidation;
using Pedidos.Application.Dtos.DtoEntities;

namespace Pedidos.Application.Validators
{
    public class CidadeValidator : ValidatorBase<CidadeDto>
    {
        public CidadeValidator()
        {
            RuleFor(x => x.Nome).NotNull().NotEmpty().WithMessage(ObterMensagemCampoObrigatorio("{PropertyName}"));
            RuleFor(x => x.EstadoId).NotNull().NotEmpty().WithMessage(ObterMensagemCampoObrigatorio("{PropertyName}"));
        }
    }
}