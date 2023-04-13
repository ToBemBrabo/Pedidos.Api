using Microsoft.AspNetCore.Mvc;
using Pedidos.Application.Dtos;
using Pedidos.Application.Dtos.DtoEntities;
using Pedidos.Application.Interfaces;
using Pedidos.Application.Validators;
using Pedidos.Domain.Entities;

namespace Pedidos.Api.Controllers
{
    public class ProdutoController : AppBaseController<Produto, ProdutoDto>
    {
        #region Fields

        protected readonly IProdutoService _produtoService;

        #endregion Fields

        #region Public Constructors

        public ProdutoController(IProdutoService produtoService) : base(produtoService)
        {
            _produtoService = produtoService;
        }

        #endregion Public Constructors

        #region Public Methods

        [HttpGet]
        [Route("Localizar")]
        public async Task<RetornoPaginado<ProdutoDto>> BuscarProdutoPorNome(string text, int pagina = 0, int registrosPorPagina = 0)
        {
            return await _produtoService.BuscarProdutoPorNome(text, pagina, registrosPorPagina);
        }

        [HttpGet]
        [Route("LocalizarPorId")]
        public async Task<ProdutoDto> ObterProdutoComIncludes(long id)
        {
            return await _produtoService.ObterProdutoComIncludes(id);
        }

        [HttpGet]
        [Route("LocalizarPorCod")]
        public async Task<ProdutoDto> ObterProdutoComIncludes(string codigo)
        {
            return await _produtoService.ObterProdutoComIncludes(codigo);
        }

        #endregion Public Methods

        #region Protected Methods

        protected override ValidatorBase<ProdutoDto> GetValidator()
            => new ProdutoValidator();

        #endregion Protected Methods
    }
}