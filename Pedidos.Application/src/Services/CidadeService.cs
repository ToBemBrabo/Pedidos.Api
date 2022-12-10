using AutoMapper;
using Pedidos.Application.src.Dtos;
using Pedidos.Application.src.Dtos.DtoEntities;
using Pedidos.Application.src.Interfaces;
using Pedidos.Domain.Entities;
using Pedidos.Infra.Data.Interfaces.Repositories;

namespace Pedidos.Application.Services
{
    public class CidadeService : ApplicationService<Cidade, CidadeDto>, ICidadeService
    {
        private readonly ICidadeRepository _cidadeRepository;

        public CidadeService(ICidadeRepository cidadeRepository, IMapper mapper) : base(cidadeRepository, mapper)
        {
            _cidadeRepository = cidadeRepository;
        }

        public async Task<RetornoPaginado<CidadeDto>> LocalizarCidadePorEstado(long estadoId, int pagina, int? registrosPorPagina)
            => ObterRetornoPaginado(await _cidadeRepository.LocalizarCidadePorEstado(estadoId, pagina, registrosPorPagina));

        public async Task<CidadeDto> LocalizarCidadePorId(long id)
            => _mapper.Map<CidadeDto>(await _cidadeRepository.GetByIdAsNoTrackingAsync(id));

        public async Task<RetornoPaginado<CidadeDto>> LocalizarCidadePorNome(string nome, int pagina, int? registrosPorPagina)
        {
            var upperNome = nome.ToUpper();

            var cidades = await _cidadeRepository.ObterCidadesPorNome(upperNome, pagina, registrosPorPagina);

            return ObterRetornoPaginado(cidades);
        }
    }
}