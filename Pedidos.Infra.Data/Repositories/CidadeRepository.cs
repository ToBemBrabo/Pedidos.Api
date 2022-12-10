using Pedidos.Domain.Dtos.RetornoPaginado;
using Pedidos.Domain.Entities;
using Pedidos.Infra.Data.Common;
using Pedidos.Infra.Data.Interfaces.Repositories;

namespace Pedidos.Infra.Data.Repositories
{
    public class CidadeRepository : ApplicationRepository<Cidade>, ICidadeRepository
    {
        public CidadeRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Task<ResultadoConsultaPaginado<Cidade>> LocalizarCidadePorEstado(long estadoId, int pagina, int? registrosPorPagina)
        {
            var cidades = GetAllAsNoTracking()
                .Where(x => x.EstadoId == estadoId)
                .OrderBy(x => x.Id);

            return GetReturnPagineted(cidades, pagina, registrosPorPagina);
        }

        public Task<ResultadoConsultaPaginado<Cidade>> ObterCidadesPorNome(string upperNome, int pagina, int? registrosPorPagina)
        {
            var cidades = GetAllAsNoTracking()
                .Where(x => x.Nome.ToUpper().Contains(upperNome))
                .OrderBy(x => x.Id);

            return GetReturnPagineted(cidades, pagina, registrosPorPagina);
        }
    }
}