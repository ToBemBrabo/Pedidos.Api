using Pedidos.Domain.Dtos.RetornoPaginado;
using Pedidos.Domain.Entities;
using Pedidos.Infra.Data.Interfaces.Repositories;

namespace Pedidos.Interface.Repositories
{
    public interface IProdutoRepository : IApplicationRepository<Produto>
    {
        Task<ResultadoConsultaPaginado<Produto>> BuscarProdutoPorNome(string text, int pagina, int registrosPorPagina);

        Task<Produto> ObterProdutoComIncludes(long id);

        Task<Produto> ObterProdutoComIncludes(string codigo);
    }
}