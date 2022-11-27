using Pedidos.Domain.Entities;
using Pedidos.Infra.Data.Common;
using Pedidos.Infra.Data.Interfaces.Repositories;

namespace Pedidos.Infra.Data.Repositories
{
    public class PessoaRepository : ApplicationRepository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}