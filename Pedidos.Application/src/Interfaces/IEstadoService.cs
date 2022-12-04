using Pedidos.Application.src.Dtos;
using Pedidos.Application.src.Dtos.DtoEntities;
using Pedidos.Domain.Entities;

namespace Pedidos.Application.src.Interfaces
{
    public interface IEstadoService : IApplicationService<Estado, EstadoDto>
    {
        #region Public Methods

        Task<RetornoPaginado<EstadoDto>> LocalizarEstadoPorDescricao(string nome, int pagina, int? registrosPorPagina);

        Task<EstadoDto> LocalizarEstadoPorId(long id);

        Task<EstadoDto> LocalizarEstadoPorUf(string uf);

        bool ValidarUFUnica(EstadoDto estado);

        #endregion Public Methods
    }
}