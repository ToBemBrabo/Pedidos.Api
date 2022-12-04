using Pedidos.Domain.Dtos.RetornoPaginado;
using Pedidos.Domain.Entities;

namespace Pedidos.Infra.Data.Interfaces.Repositories
{
    public interface IEstadoRepository : IApplicationRepository<Estado>
    {
        Task<ResultadoConsultaPaginado<Estado>> LocalizarEstadoPorDescricao(string descricao, int pagina, int? registrosPorPagina);

        Task<Estado> ObterEstadoPorUf(string uf);

        bool ValidarUFUnica(string uf, long id);
    }
}