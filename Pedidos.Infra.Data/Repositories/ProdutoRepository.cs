using Microsoft.EntityFrameworkCore;
using Pedidos.Domain.Dtos.RetornoPaginado;
using Pedidos.Domain.Entities;
using Pedidos.Infra.Data.Common;
using Pedidos.Interface.Repositories;

namespace Pedidos.Infra.Data.Repositories
{
    public class ProdutoRepository : ApplicationRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ApplicationDbContext context) : base(context)
        {
        }

        private IQueryable<Produto> includesProduto => GetAllAsNoTracking()
                .Include(x => x.Imagens)
                .Include(x => x.Categoria)
                .Include(x => x.ListaPrecoProduto)
                    .ThenInclude(x => x.ListaPreco);

        public async Task<ResultadoConsultaPaginado<Produto>> BuscarProdutoPorNome(string text, int pagina)
        {
            var result = GetAllAsNoTracking()
                .Where(x => x.Nome.ToUpper().Contains(text))
                .OrderBy(x => x.Codigo);

            return await GetReturnPagineted(pagina, result);
        }

        public async Task<Produto> ObterProdutoComIncludes(long id)
        {
            return await includesProduto.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Produto> ObterProdutoComIncludes(string codigo)
        {
            return await includesProduto.FirstOrDefaultAsync(x => x.Codigo == codigo);
        }
    }
}