using Pedidos.Application.Dtos.DtoEntities;
using Pedidos.Domain.Entities;

namespace Pedidos.Application.Interfaces
{
    public interface IEnderecoService : IApplicationService<Endereco, EnderecoDto>
    {
        Task<EnderecoDto> ObterEnderecoPorId(long enderecoId);
    }
}