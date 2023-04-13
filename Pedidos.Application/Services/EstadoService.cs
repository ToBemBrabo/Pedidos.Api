using AutoMapper;
using Pedidos.Application.Dtos;
using Pedidos.Application.Dtos.DtoEntities;
using Pedidos.Application.Interfaces;
using Pedidos.Domain.Entities;
using Pedidos.Infra.Data.Interfaces.Repositories;

namespace Pedidos.Application.Services
{
    public class EstadoService : ApplicationService<Estado, EstadoDto>, IEstadoService
    {
        #region Fields

        private readonly IEstadoRepository _estadoRepository;

        #endregion Fields

        #region Public Constructors

        public EstadoService(IEstadoRepository estadoRepository, IMapper mapper) : base(estadoRepository, mapper)
        {
            _estadoRepository = estadoRepository;
        }

        #endregion Public Constructors

        #region Public Methods

        public async Task<RetornoPaginado<EstadoDto>> LocalizarEstadoPorDescricao(string descricao, int pagina, int? registrosPorPagina)
        {
            var textUpper = descricao.ToUpper();

            var result = await _estadoRepository.LocalizarEstadoPorDescricao(textUpper, pagina, registrosPorPagina);

            return ObterRetornoPaginado(result);
        }

        public async Task<EstadoDto> LocalizarEstadoPorId(long id)
                    => _mapper.Map<EstadoDto>(await _estadoRepository.GetByIdAsNoTrackingAsync(id));

        public async Task<EstadoDto> LocalizarEstadoPorUf(string uf)
            => _mapper.Map<EstadoDto>(await _estadoRepository.ObterEstadoPorUf(uf));

        public bool ValidarUFUnica(EstadoDto estado)
            => _estadoRepository.ValidarUFUnica(estado.Uf, estado.Id);

        #endregion Public Methods
    }
}