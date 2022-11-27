using AutoMapper;
using Pedidos.Application.src.Dtos.DtoEntities;
using Pedidos.Application.src.Interfaces;
using Pedidos.Domain.Entities;
using Pedidos.Infra.Data.Interfaces.Repositories;

namespace Pedidos.Application.Services
{
    public class PessoaService : ApplicationService<Pessoa, PessoaDto>, IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository, IMapper mapper) : base(pessoaRepository, mapper)
        {
            _pessoaRepository = pessoaRepository;
        }
    }
}