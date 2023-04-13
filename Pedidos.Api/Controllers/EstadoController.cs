using Microsoft.AspNetCore.Mvc;
using Pedidos.Application.Dtos;
using Pedidos.Application.Dtos.DtoEntities;
using Pedidos.Application.Interfaces;
using Pedidos.Application.Validators;
using Pedidos.Domain.Entities;

namespace Pedidos.Api.Controllers
{
    public class EstadoController : AppBaseController<Estado, EstadoDto>
    {
        #region Fields

        private readonly IEstadoService _estadoService;

        #endregion Fields

        #region Public Constructors

        public EstadoController(IEstadoService estadoService) : base(estadoService)
        {
            _estadoService = estadoService;
        }

        #endregion Public Constructors

        #region Public Methods

        [HttpGet]
        [Route("LocalizarPorId")]
        public async Task<EstadoDto> LocalizarPaisPorId(long id)
        {
            return await _estadoService.LocalizarEstadoPorId(id);
        }

        [HttpGet]
        [Route("LocalizarPorNome")]
        public async Task<RetornoPaginado<EstadoDto>> LocalizarPaisPorNome(string nome, int pagina = 0, int? registrosPorPagina = 0)
        {
            return await _estadoService.LocalizarEstadoPorDescricao(nome, pagina, registrosPorPagina);
        }

        [HttpGet]
        [Route("LocalizarPorUf")]
        public async Task<EstadoDto> LocalizarPaisPorUf(string uf)
        {
            return await _estadoService.LocalizarEstadoPorUf(uf);
        }

        #endregion Public Methods

        #region Protected Methods

        protected override ValidatorBase<EstadoDto> GetValidator()
            => new EstadoValidator(_estadoService);

        #endregion Protected Methods
    }
}