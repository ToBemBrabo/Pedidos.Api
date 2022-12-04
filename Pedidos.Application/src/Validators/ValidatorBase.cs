using FluentValidation;
using Pedidos.Application.src.Dtos.DtoEntities;

namespace Pedidos.Application.src.Validators
{
    public class ValidatorBase<TDto> : AbstractValidator<TDto> where TDto : BaseDto
    {
        public ValidatorBase()
        {
        }

        protected string ObterMensagemCampoObrigatorio(string propertyName)
            => $"O campo {propertyName} é obrigatório.";

        protected string ObterMensagemValorInvalido(string propertyName)
            => $"O valor informado no campo {propertyName} é inválido.";
    }
}