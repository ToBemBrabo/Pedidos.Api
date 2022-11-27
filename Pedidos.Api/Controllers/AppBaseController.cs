using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Pedidos.Application.src.Dtos;
using Pedidos.Application.src.Dtos.DtoEntities;
using Pedidos.Application.src.Interfaces;
using Pedidos.Application.src.Services;
using Pedidos.Application.src.Validators;
using Pedidos.Domain.Dtos.RetornoPaginado;
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
        [Route("Cadastrar")]
        public async Task<ResultService<TDto>> Cadastrar([FromBody] TDto model)
        {
            if (model is null)
                return ResultService.Fail<TDto>("Objeto nulo é inválido.");

            var resultadoValidacao = ValidarModel(model);

            if (!resultadoValidacao.IsValid)
                return ResultService.RequestError<TDto>("Ocorreram erros de validação, verifique.", resultadoValidacao);

            return await _applicationService.Cadastrar(model);
        }

        [HttpGet]
        [Route("Listar")]
        public async Task<RetornoPaginado<TDto>> ListarAsync(int pagina = 1)
        {
            return await _applicationService.Listar(pagina);
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