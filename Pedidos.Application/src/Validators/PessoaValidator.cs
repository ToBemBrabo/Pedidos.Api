using FluentValidation;
using Pedidos.Application.src.Dtos.DtoEntities;
using Pedidos.Application.src.Extensions;
using Pedidos.Domain.Enums;

namespace Pedidos.Application.src.Validators
{
    public class PessoaValidator : ValidatorBase<PessoaDto>
    {
        public PessoaValidator()
        {
            RuleFor(x => x.TipoPessoa).NotNull().NotEmpty().WithMessage(ObterMensagemCampoObrigatorio("{PropertyName}"));
            RuleFor(x => x.Nome).NotNull().NotEmpty().WithMessage(ObterMensagemCampoObrigatorio("{PropertyName}"));
            RuleFor(x => x).Custom((pessoa, context) =>
            {
                if (pessoa.TipoPessoa == TipoPessoaEnum.Fisica)
                {
                    if (string.IsNullOrEmpty(pessoa.Cpf))
                        context.AddFailure(ObterMensagemCampoObrigatorio(pessoa.Cpf.GetType().Name));

                    if (!string.IsNullOrEmpty(pessoa.Cnpj))
                        context.AddFailure("Para pessoa física não deve ser informada o CNPJ.");

                    if (!pessoa.Cpf.CpfIsValid())
                        context.AddFailure(ObterMensagemValorInvalido(pessoa.Cpf.GetType().Name));
                }
                else
                {
                    if (string.IsNullOrEmpty(pessoa.Cnpj))
                        context.AddFailure(ObterMensagemCampoObrigatorio(pessoa.Cnpj.GetType().Name));

                    if (!string.IsNullOrEmpty(pessoa.Cpf))
                        context.AddFailure("Para pessoa física não deve ser informada o CPF.");

                    if (!pessoa.Cnpj.CnpjIsValid())
                        context.AddFailure(ObterMensagemValorInvalido(pessoa.Cnpj.GetType().Name));
                }
            });
        }
    }
}