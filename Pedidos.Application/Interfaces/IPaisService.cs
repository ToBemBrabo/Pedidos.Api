using Pedidos.Application.Dtos;
using Pedidos.Application.Dtos.DtoEntities;
using Pedidos.Domain.Entities;

namespace Pedidos.Application.Interfaces
{
    public interface IPaisService : IApplicationService<Pais, PaisDto>
    {
        Task<PaisDto> LocalizarPaisPorId(long id);

        Task<RetornoPaginado<PaisDto>> LocalizarPaisPorNome(string nome, int pagina, int? registrosPorPagina);
    }
}