using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Pedidos.Application.Dtos;
using Pedidos.Application.Dtos.DtoEntities;
using Pedidos.Application.Interfaces;
using Pedidos.Application.Services;
using Pedidos.Application.Validators;
using Pedidos.Domain.Entities;

namespace Pedidos.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class AppBaseController<TEntity, TDto> : ControllerBase where TEntity : EntityBase where TDto : BaseDto
    {
        #region Fields

        protected readonly IApplicationService<TEntity, TDto> _applicationService;

        #endregion Fields

        #region Public Constructors

        public AppBaseController(IApplicationService<TEntity, TDto> applicationService)
        {
            _applicationService = applicationService;
        }

        #endregion Public Constructors

        #region Public Methods

        [HttpPost]
        [Route("CadastrarAtualizar")]
        public async Task<ResultService<TDto>> CadastrarAtualizar([FromBody] TDto model)
        {
            if (model is null)
                return ResultService.Fail<TDto>("Objeto nulo é inválido.");

            var resultadoValidacao = ValidarModel(model);

            if (!resultadoValidacao.IsValid)
                return ResultService.RequestError<TDto>("Ocorreram erros de validação, verifique.", resultadoValidacao);

            return await _applicationService.CadastrarAtualizar(model);
        }

        [HttpGet]
        [Route("Listar")]
        public async Task<RetornoPaginado<TDto>> Listar(int pagina = 0, int registrosPorPagina = 0)
        {
            return await _applicationService.Listar(pagina, registrosPorPagina);
        }

        #endregion Public Methods

        #region Protected Methods

        protected abstract ValidatorBase<TDto> GetValidator();

        protected virtual ValidationResult ValidarModel(TDto model)
        {
            var validator = GetValidator();

            return validator.Validate(model);
        }

        #endregion Protected Methods
    }
}