using AutoMapper;
using Pedidos.Application.Dtos.DtoEntities;
using Pedidos.Domain.Entities;

namespace Pedidos.Application.Maps
{
    public class EstadoMapper : Profile
    {
        public EstadoMapper()
        {
            CreateMap<Estado, EstadoDto>().ReverseMap();
        }
    }
}