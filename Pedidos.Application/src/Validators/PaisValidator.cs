using FluentValidation;
using Pedidos.Application.src.Dtos.DtoEntities;

namespace Pedidos.Application.src.Validators
{
    public class PaisValidator : ValidatorBase<PaisDto>
    {
        public PaisValidator()
        {
            RuleFor(x => x.Nome).NotNull().NotEmpty().WithMessage(ObterMensagemCampoObrigatorio("{PropertyName}"));
        }
    }
}