using AutoMapper;
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
    }
}