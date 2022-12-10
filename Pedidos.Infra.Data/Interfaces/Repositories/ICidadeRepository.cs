using Pedidos.Domain.Dtos.RetornoPaginado;
using Pedidos.Domain.Entities;

namespace Pedidos.Infra.Data.Interfaces.Repositories
{
    public interface ICidadeRepository : IApplicationRepository<Cidade>
    {
        Task<ResultadoConsultaPaginado<Cidade>> LocalizarCidadePorEstado(long estadoId, int pagina, int? registrosPorPagina);

        Task<ResultadoConsultaPaginado<Cidade>> ObterCidadesPorNome(string upperNome, int pagina, int? registrosPorPagina);
    }
}