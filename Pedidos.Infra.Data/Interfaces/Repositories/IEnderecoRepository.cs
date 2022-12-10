using Pedidos.Domain.Entities;

namespace Pedidos.Infra.Data.Interfaces.Repositories
{
    public interface IEnderecoRepository : IApplicationRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoComIncludes(long enderecoId);
    }
}