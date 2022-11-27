using Pedidos.Application.src.Dtos.DtoEntities;
using Pedidos.Application.src.Interfaces;
using Pedidos.Application.src.Validators;
using Pedidos.Domain.Entities;

namespace Pedidos.Api.Controllers
{
    public class EstadoController : AppBaseController<Estado, EstadoDto>
    {
        public EstadoController(IEstadoService estadoService) : base(estadoService)
        {
        }

        protected override ValidatorBase<EstadoDto> GetValidator()
            => new EstadoValidator();
    }
}