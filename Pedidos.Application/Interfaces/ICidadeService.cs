using Pedidos.Application.Dtos;
using Pedidos.Application.Dtos.DtoEntities;
using Pedidos.Domain.Entities;

namespace Pedidos.Application.Interfaces
{
    public interface ICidadeService : IApplicationService<Cidade, CidadeDto>
    {
        Task<RetornoPaginado<CidadeDto>> LocalizarCidadePorEstado(long estadoId, int pagina, int? registrosPorPagina);

        Task<CidadeDto> LocalizarCidadePorId(long id);

        Task<RetornoPaginado<CidadeDto>> LocalizarCidadePorNome(string nome, int pagina, int? registrosPorPagina);
    }
}