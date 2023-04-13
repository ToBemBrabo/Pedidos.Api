using AutoMapper;
using Pedidos.Application.Dtos;
using Pedidos.Application.Dtos.DtoEntities;
using Pedidos.Application.Interfaces;
using Pedidos.Domain.Entities;
using Pedidos.Infra.Data.Interfaces.Repositories;

namespace Pedidos.Application.Services
{
    public class PaisService : ApplicationService<Pais, PaisDto>, IPaisService
    {
        #region Fields

        private readonly IPaisRepository _paisRepository;

        #endregion Fields

        #region Public Constructors

        public PaisService(IPaisRepository paisRepository, IMapper mapper) : base(paisRepository, mapper)
        {
            _paisRepository = paisRepository;
        }

        #endregion Public Constructors

        #region Public Methods

        public async Task<PaisDto> LocalizarPaisPorId(long id)
            => _mapper.Map<PaisDto>(await _paisRepository.GetByIdAsNoTrackingAsync(id));

        public async Task<RetornoPaginado<PaisDto>> LocalizarPaisPorNome(string nome, int pagina, int? registrosPorPagina)
        {
            var upperText = nome.ToUpper();

            var resultado = await _paisRepository.BuscarPaisPorNome(upperText, pagina, registrosPorPagina);

            return ObterRetornoPaginado(resultado);
        }

        #endregion Public Methods
    }
}