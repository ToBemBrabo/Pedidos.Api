using AutoMapper;
using Pedidos.Application.src.Dtos.DtoEntities;
using Pedidos.Application.src.Interfaces;
using Pedidos.Application.src.Validators;
using Pedidos.Domain.Entities;
using Pedidos.Infra.Data.Interfaces.Repositories;

namespace Pedidos.Application.Services
{
    public class EstadoService : ApplicationService<Estado, EstadoDto>, IEstadoService
    {
        private readonly IEstadoRepository _estadoRepository;

        public EstadoService(IEstadoRepository estadoRepository, IMapper mapper) : base(estadoRepository, mapper)
        {
            _estadoRepository = estadoRepository;
        }
    }
}