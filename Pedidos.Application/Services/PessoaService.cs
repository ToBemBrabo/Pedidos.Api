using AutoMapper;
using Pedidos.Application.Dtos.DtoEntities;
using Pedidos.Application.Interfaces;
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