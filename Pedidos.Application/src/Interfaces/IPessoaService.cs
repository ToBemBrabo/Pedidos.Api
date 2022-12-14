using Pedidos.Application.src.Dtos.DtoEntities;
using Pedidos.Domain.Entities;

namespace Pedidos.Application.src.Interfaces
{
    public interface IPessoaService : IApplicationService<Pessoa, PessoaDto>
    {
    }
}