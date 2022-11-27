using Pedidos.Application.src.Dtos.DtoEntities;
using Pedidos.Domain.Entities;

namespace Pedidos.Application.src.Interfaces
{
    public interface IEnderecoService : IApplicationService<Endereco, EnderecoDto>
    {
    }
}