using AutoMapper;
using Pedidos.Application.Dtos.DtoEntities;
using Pedidos.Domain.Entities;

namespace Pedidos.Application.Maps
{
    public class CidadeMapper : Profile
    {
        public CidadeMapper()
        {
            CreateMap<Cidade, CidadeDto>().ReverseMap();
        }
    }
}