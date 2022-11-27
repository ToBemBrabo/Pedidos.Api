using Pedidos.Application.src.Dtos;
using Pedidos.Application.src.Dtos.DtoEntities;
using Pedidos.Domain.Entities;

namespace Pedidos.Application.src.Interfaces
{
    public interface IProdutoService : IApplicationService<Produto, ProdutoDto>
    {
        Task<RetornoPaginado<ProdutoDto>> BuscarProdutoPorNome(string text, int pagina);

        Task<ProdutoDto> ObterProdutoComIncludes(long id);

        Task<ProdutoDto> ObterProdutoComIncludes(string codigo);
    }
}