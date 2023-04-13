using Microsoft.AspNetCore.Mvc;
using Pedidos.Application.Dtos;
using Pedidos.Application.Dtos.DtoEntities;
using Pedidos.Application.Interfaces;
using Pedidos.Application.Validators;
using Pedidos.Domain.Entities;

namespace Pedidos.Api.Controllers
{
    public class PaisController : AppBaseController<Pais, PaisDto>
    {
        #region Fields

        private readonly IPaisService _paisService;

        #endregion Fields

        #region Public Constructors

        public PaisController(IPaisService paisService) : base(paisService)
        {
            _paisService = paisService;
        }

        #endregion Public Constructors

        #region Public Methods

        [HttpGet]
        [Route("LocalizarPorId")]
        public async Task<PaisDto> LocalizarPaisPorId(long id)
        {
            return await _paisService.LocalizarPaisPorId(id);
        }

        [HttpGet]
        [Route("LocalizarPorNome")]
        public async Task<RetornoPaginado<PaisDto>> LocalizarPaisPorNome(string nome, int pagina = 0, int? registrosPorPagina = 0)
        {
            return await _paisService.LocalizarPaisPorNome(nome, pagina, registrosPorPagina);
        }

        #endregion Public Methods

        #region Protected Methods

        protected override ValidatorBase<PaisDto> GetValidator()
            => new PaisValidator();

        #endregion Protected Methods
    }
}