using AutoMapper;
using Pedidos.Application.src.Dtos.DtoEntities;
using Pedidos.Application.src.Interfaces;
using Pedidos.Domain.Entities;
using Pedidos.Infra.Data.Interfaces.Repositories;

namespace Pedidos.Application.Services
{
    public class EnderecoService : ApplicationService<Endereco, EnderecoDto>, IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoService(IEnderecoRepository enderecoRepository, IMapper mapper) : base(enderecoRepository, mapper)
        {
            _enderecoRepository = enderecoRepository;
        }

        public async Task<EnderecoDto> ObterEnderecoPorId(long enderecoId)
            => _mapper.Map<EnderecoDto>(await _enderecoRepository.ObterEnderecoComIncludes(enderecoId));
    }
}