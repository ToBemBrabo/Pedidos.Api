using FluentValidation;
using Pedidos.Application.Dtos.DtoEntities;
using Pedidos.Application.Interfaces;

namespace Pedidos.Application.Validators
{
    public class EstadoValidator : ValidatorBase<EstadoDto>
    {
        private readonly IEstadoService _estadoService;

        public EstadoValidator(IEstadoService estadoService)
        {
            _estadoService = estadoService;

            RuleFor(x => x.Descricao).NotNull().NotEmpty().WithMessage(ObterMensagemCampoObrigatorio("{PropertyName}"));
            RuleFor(x => x.PaisId).NotNull().NotEmpty().WithMessage(ObterMensagemCampoObrigatorio("{PropertyName}"));
            RuleFor(x => x.Uf).NotNull().NotEmpty().WithMessage(ObterMensagemCampoObrigatorio("{PropertyName}"))
                .Must(ValidarQuantidadeCaracteresUf).WithMessage(ObterMensagemValorInvalido("{PropertyName}"))
                .Must(ValidarUfUnica).WithMessage("A UF informada já está cadastrada.");
        }

        private bool ValidarUfUnica(EstadoDto estado, string uf)
            => _estadoService.ValidarUFUnica(estado);

        private bool ValidarQuantidadeCaracteresUf(string uf) => uf.Length <= 2;
    }
}