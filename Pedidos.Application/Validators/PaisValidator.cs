using FluentValidation;
using Pedidos.Application.Dtos.DtoEntities;

namespace Pedidos.Application.Validators
{
    public class PaisValidator : ValidatorBase<PaisDto>
    {
        public PaisValidator()
        {
            RuleFor(x => x.Nome).NotNull().NotEmpty().WithMessage(ObterMensagemCampoObrigatorio("{PropertyName}"));
        }
    }
}