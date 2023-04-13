using Pedidos.Application.Dtos.DtoEntities;
using Pedidos.Domain.Entities;

namespace Pedidos.Application.Interfaces
{
    public interface IPessoaService : IApplicationService<Pessoa, PessoaDto>
    {
    }
}