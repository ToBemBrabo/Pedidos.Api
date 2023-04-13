using FluentValidation;
using Pedidos.Application.Dtos.DtoEntities;
using Pedidos.Application.Extensions;

namespace Pedidos.Application.Validators
{
    public class EnderecoValidator : ValidatorBase<EnderecoDto>
    {
        public EnderecoValidator()
        {
            RuleFor(x => x.Bairro).NotNull().NotEmpty().WithMessage(ObterMensagemCampoObrigatorio("{PropertyName}"));
            RuleFor(x => x.Logradouro).NotNull().NotEmpty().WithMessage(ObterMensagemCampoObrigatorio("{PropertyName}"));
            RuleFor(x => x.Bairro).NotNull().NotEmpty().WithMessage(ObterMensagemCampoObrigatorio("{PropertyName}"));
            RuleFor(x => x.CidadeId).NotNull().NotEmpty().WithMessage(ObterMensagemCampoObrigatorio("{PropertyName}"));
            RuleFor(x => x.Cep).NotNull().NotEmpty().WithMessage(ObterMensagemCampoObrigatorio("{PropertyName}"))
                .Must(ValidarCep).WithMessage(ObterMensagemValorInvalido("{PropertyName}"));
            RuleFor(x => x.Numero).NotNull().NotEmpty().WithMessage(ObterMensagemCampoObrigatorio("{PropertyName}"))
                .Must(ValidarNumero).WithMessage(ObterMensagemValorInvalido("{PropertyName}"));
        }

        private bool ValidarCep(string cep)
            => StringExtensions.ValidarCep(cep);

        private bool ValidarNumero(string numero)
        {
            if (string.IsNullOrEmpty(numero))
                return false;

            return numero.Length > 0 && numero.ValidarOnlyNumbers();
        }
    }
}