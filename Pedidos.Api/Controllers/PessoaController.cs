using Pedidos.Application.Dtos.DtoEntities;
using Pedidos.Application.Interfaces;
using Pedidos.Application.Validators;
using Pedidos.Domain.Entities;

namespace Pedidos.Api.Controllers
{
    public class PessoaController : AppBaseController<Pessoa, PessoaDto>
    {
        private readonly IPessoaService _pessoaService;

        public PessoaController(IPessoaService pessoaService) : base(pessoaService)
        {
        }

        protected override ValidatorBase<PessoaDto> GetValidator()
            => new PessoaValidator();
    }
}