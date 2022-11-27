using Pedidos.Domain.Entities;

namespace Pedidos.Application.src.Dtos.DtoEntities
{
    public class CidadeDto : BaseDto
    {
        public string Nome { get; set; }

        public long EstadoId { get; set; }

        public Estado Estado { get; set; }
    }
}