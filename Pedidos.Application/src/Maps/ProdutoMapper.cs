using AutoMapper;
using Pedidos.Application.src.Dtos.DtoEntities;
using Pedidos.Domain.Entities;

namespace Pedidos.Application.src.Maps
{
    public class ProdutoMapper : Profile
    {
        public ProdutoMapper()
        {
            CreateMap<Produto, ProdutoDto>().ReverseMap();
        }
    }
}