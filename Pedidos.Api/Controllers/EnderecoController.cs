using Microsoft.AspNetCore.Mvc;
using Pedidos.Application.Dtos.DtoEntities;
using Pedidos.Application.Interfaces;
using Pedidos.Application.Validators;
using Pedidos.Domain.Entities;

namespace Pedidos.Api.Controllers
{
    public class EnderecoController : AppBaseController<Endereco, EnderecoDto>
    {
        #region Fields

        private readonly IEnderecoService _enderecoService;

        #endregion Fields

        #region Public Constructors

        public EnderecoController(IEnderecoService enderecoService) : base(enderecoService)
        {
            _enderecoService = enderecoService;
        }

        #endregion Public Constructors

        #region Public Methods

        [HttpGet]
        [Route("LocalizarPorId")]
        public async Task<EnderecoDto> LocalizarEnderecoPorId(long enderecoId)
        {
            return await _enderecoService.ObterEnderecoPorId(enderecoId);
        }

        #endregion Public Methods

        #region Protected Methods

        protected override ValidatorBase<EnderecoDto> GetValidator()
            => new EnderecoValidator();

        #endregion Protected Methods
    }
}