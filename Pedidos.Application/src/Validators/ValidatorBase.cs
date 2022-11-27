using FluentValidation;
using Pedidos.Application.src.Dtos.DtoEntities;

namespace Pedidos.Application.src.Validators
{
    public class ValidatorBase<TDto> : AbstractValidator<TDto> where TDto : BaseDto
    {
        public ValidatorBase()
        {
        }
    }
}