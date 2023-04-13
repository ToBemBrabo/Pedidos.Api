using Pedidos.Application.Dtos;
using Pedidos.Application.Dtos.DtoEntities;
using Pedidos.Domain.Entities;

namespace Pedidos.Application.Interfaces
{
    public interface IProdutoService : IApplicationService<Produto, ProdutoDto>
    {
        Task<RetornoPaginado<ProdutoDto>> BuscarProdutoPorNome(string text, int pagina, int registrosPorPagina);

        Task<ProdutoDto> ObterProdutoComIncludes(long id);

        Task<ProdutoDto> ObterProdutoComIncludes(string codigo);
    }
}