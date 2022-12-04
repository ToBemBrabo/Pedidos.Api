using Microsoft.EntityFrameworkCore;
using Pedidos.Domain.Dtos.RetornoPaginado;
using Pedidos.Domain.Entities;
using Pedidos.Infra.Data.Common;
using Pedidos.Infra.Data.Interfaces.Repositories;

namespace Pedidos.Infra.Data.Repositories
{
    public class EstadoRepository : ApplicationRepository<Estado>, IEstadoRepository
    {
        public EstadoRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Task<ResultadoConsultaPaginado<Estado>> LocalizarEstadoPorDescricao(string descricao, int pagina, int? registrosPorPagina)
        {
            var result = GetAllAsNoTracking()
                .Where(x => x.Descricao.ToUpper().Contains(descricao))
                .OrderBy(x => x.Id);

            return GetReturnPagineted(result, pagina, registrosPorPagina);
        }

        public async Task<Estado> ObterEstadoPorUf(string uf)
        {
            return await GetAllAsNoTracking().FirstOrDefaultAsync(x => x.Uf == uf.ToUpper());
        }

        public bool ValidarUFUnica(string uf, long id)
        {
            return !GetAllAsNoTracking().Any(x => x.Uf == uf.ToUpper() && x.Id != id);
        }
    }
}