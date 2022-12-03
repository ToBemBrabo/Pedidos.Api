using FluentValidation;
using Pedidos.Application.src.Dtos.DtoEntities;

namespace Pedidos.Application.src.Validators
{
    public class CidadeValidator : ValidatorBase<CidadeDto>
    {
        public CidadeValidator()
        {
            RuleFor(x => x.Nome).NotNull().NotEmpty().WithMessage(ObterMensagemCampoObrigatorio("{PropertyName}"));
        }
    }
}