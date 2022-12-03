using Pedidos.Domain.Dtos.RetornoPaginado;
using Pedidos.Domain.Entities;
using Pedidos.Infra.Data.Common;
using Pedidos.Infra.Data.Interfaces.Repositories;

namespace Pedidos.Infra.Data.Repositories
{
    public class PaisRepository : ApplicationRepository<Pais>, IPaisRepository
    {
        public PaisRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Task<ResultadoConsultaPaginado<Pais>> BuscarPaisPorNome(string upperText, int pagina, int? registrosPorPagina)
        {
            var result = GetAllAsNoTracking()
                .Where(x => x.Nome.ToUpper().Contains(upperText))
                .OrderBy(x => x.Id);

            return GetReturnPagineted(pagina, result, registrosPorPagina);
        }
    }
}