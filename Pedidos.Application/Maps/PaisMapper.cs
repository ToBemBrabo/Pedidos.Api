using AutoMapper;
using Pedidos.Application.Dtos.DtoEntities;
using Pedidos.Domain.Entities;

namespace Pedidos.Application.Maps
{
    public class PaisMapper : Profile
    {
        public PaisMapper()
        {
            CreateMap<Pais, PaisDto>().ReverseMap();
        }
    }
}