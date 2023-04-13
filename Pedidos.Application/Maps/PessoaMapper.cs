using AutoMapper;
using Pedidos.Application.Dtos.DtoEntities;
using Pedidos.Domain.Entities;

namespace Pedidos.Application.Maps
{
    public class PessoaMapper : Profile
    {
        public PessoaMapper()
        {
            CreateMap<Pessoa, PessoaDto>().ReverseMap();
        }
    }
}