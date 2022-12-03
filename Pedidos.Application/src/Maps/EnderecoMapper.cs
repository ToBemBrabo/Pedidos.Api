using AutoMapper;
using Pedidos.Application.src.Dtos.DtoEntities;
using Pedidos.Domain.Entities;

namespace Pedidos.Application.src.Maps
{
    public class EnderecoMapper : Profile
    {
        public EnderecoMapper()
        {
            CreateMap<Endereco, EnderecoDto>().ReverseMap();
        }
    }
}