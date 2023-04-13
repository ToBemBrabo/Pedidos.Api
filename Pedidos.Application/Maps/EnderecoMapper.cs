using AutoMapper;
using Pedidos.Application.Dtos.DtoEntities;
using Pedidos.Domain.Entities;

namespace Pedidos.Application.Maps
{
    public class EnderecoMapper : Profile
    {
        public EnderecoMapper()
        {
            CreateMap<Endereco, EnderecoDto>().ReverseMap();
        }
    }
}