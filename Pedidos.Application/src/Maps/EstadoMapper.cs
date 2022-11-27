using AutoMapper;
using Pedidos.Application.src.Dtos.DtoEntities;
using Pedidos.Domain.Entities;

namespace Pedidos.Application.src.Maps
{
    public class EstadoMapper : Profile
    {
        public EstadoMapper()
        {
            CreateMap<Estado, EstadoDto>().ReverseMap();
        }
    }
}