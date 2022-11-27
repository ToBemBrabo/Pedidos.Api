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
    }
}