using AutoMapper;
using Pedidos.Application.src.Dtos.DtoEntities;
using Pedidos.Domain.Entities;

namespace Pedidos.Application.src.Maps
{
    public class PaisMapper : Profile
    {
        public PaisMapper()
        {
            CreateMap<Pais, PaisDto>().ReverseMap();
        }
    }
}