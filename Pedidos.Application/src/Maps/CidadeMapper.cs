using AutoMapper;
using Pedidos.Application.src.Dtos.DtoEntities;
using Pedidos.Domain.Entities;

namespace Pedidos.Application.src.Maps
{
    public class CidadeMapper : Profile
    {
        public CidadeMapper()
        {
            CreateMap<Cidade, CidadeDto>().ReverseMap();
        }
    }
}