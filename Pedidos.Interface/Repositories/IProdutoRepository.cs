using Pedidos.Domain.Dtos.RetornoPaginado;
using Pedidos.Domain.Entities;

namespace Pedidos.Interface.Repositories
{
    public interface IProdutoRepository : IApplicationRepository<Produto>
    {
        Task<RetornoPaginado<Produto>> BuscarProdutoPorNome(string text, int pagina);

        Task<Produto> ObterProdutoComIncludes(long id);

        Task<Produto> ObterProdutoComIncludes(string codigo);
    }
}