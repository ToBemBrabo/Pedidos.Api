using Pedidos.Domain.Entities;
using Pedidos.Infra.Data.Common;
using Pedidos.Infra.Data.Interfaces.Repositories;

namespace Pedidos.Infra.Data.Repositories
{
    public class EnderecoRepository : ApplicationRepository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}