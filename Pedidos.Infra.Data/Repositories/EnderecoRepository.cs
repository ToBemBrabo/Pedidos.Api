using Microsoft.EntityFrameworkCore;
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

        private IQueryable<Endereco> EnderecosComIncludes
            => GetAllAsNoTracking().Include(x => x.Cidade.Estado.Pais);

        public async Task<Endereco> ObterEnderecoComIncludes(long enderecoId)
        {
            return await EnderecosComIncludes.FirstOrDefaultAsync(x => x.Id == enderecoId);
        }
    }
}