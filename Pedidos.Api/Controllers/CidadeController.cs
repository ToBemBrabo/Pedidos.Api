using Microsoft.AspNetCore.Mvc;
using Pedidos.Application.src.Dtos;
using Pedidos.Application.src.Dtos.DtoEntities;
using Pedidos.Application.src.Interfaces;
using Pedidos.Application.src.Validators;
using Pedidos.Domain.Entities;

namespace Pedidos.Api.Controllers
{
    public class CidadeController : AppBaseController<Cidade, CidadeDto>
    {
        #region Fields

        private readonly ICidadeService _cidadeService;

        #endregion Fields

        #region Public Constructors

        public CidadeController(ICidadeService cidadeService) : base(cidadeService)
        {
            _cidadeService = cidadeService;
        }

        #endregion Public Constructors

        #region Public Methods

        [HttpGet]
        [Route("LocalizarPorId")]
        public async Task<CidadeDto> LocalizarCidadePorId(long id)
        {
            return await _cidadeService.LocalizarCidadePorId(id);
        }

        [HttpGet]
        [Route("LocalizarPorNome")]
        public async Task<RetornoPaginado<CidadeDto>> LocalizarCidadePorNome(string nome, int pagina = 0, int? registrosPorPagina = 0)
        {
            return await _cidadeService.LocalizarCidadePorNome(nome, pagina, registrosPorPagina);
        }

        [HttpGet]
        [Route("LocalizarPorEstado")]
        public async Task<RetornoPaginado<CidadeDto>> LocalizarCidadePorEstado(long estadoId, int pagina = 0, int? registrosPorPagina = 0)
        {
            return await _cidadeService.LocalizarCidadePorEstado(estadoId, pagina, registrosPorPagina);
        }

        #endregion Public Methods

        #region Protected Methods

        protected override ValidatorBase<CidadeDto> GetValidator()
            => new CidadeValidator();

        #endregion Protected Methods
    }
}