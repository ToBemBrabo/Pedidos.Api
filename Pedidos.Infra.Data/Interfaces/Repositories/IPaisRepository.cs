using Pedidos.Domain.Dtos.RetornoPaginado;
using Pedidos.Domain.Entities;

namespace Pedidos.Infra.Data.Interfaces.Repositories
{
    public interface IPaisRepository : IApplicationRepository<Pais>
    {
        Task<ResultadoConsultaPaginado<Pais>> BuscarPaisPorNome(string upperText, int pagina, int? registrosPorPagina);
    }
}