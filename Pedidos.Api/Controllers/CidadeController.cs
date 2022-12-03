using Pedidos.Application.src.Dtos.DtoEntities;
using Pedidos.Application.src.Interfaces;
using Pedidos.Application.src.Validators;
using Pedidos.Domain.Entities;

namespace Pedidos.Api.Controllers
{
    public class CidadeController : AppBaseController<Cidade, CidadeDto>
    {
        public CidadeController(ICidadeService cidadeService) : base(cidadeService)
        {
        }

        protected override ValidatorBase<CidadeDto> GetValidator()
            => new CidadeValidator();
    }
}