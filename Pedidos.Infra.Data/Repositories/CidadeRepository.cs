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
    }
}