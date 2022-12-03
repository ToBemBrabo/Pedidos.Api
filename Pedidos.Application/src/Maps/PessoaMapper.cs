using AutoMapper;
using Pedidos.Application.src.Dtos.DtoEntities;
using Pedidos.Domain.Entities;

namespace Pedidos.Application.src.Maps
{
    public class PessoaMapper : Profile
    {
        public PessoaMapper()
        {
            CreateMap<Pessoa, PessoaDto>().ReverseMap();
        }
    }
}