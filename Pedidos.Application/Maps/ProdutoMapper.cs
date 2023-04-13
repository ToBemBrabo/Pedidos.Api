using AutoMapper;
using Pedidos.Application.Dtos.DtoEntities;
using Pedidos.Domain.Entities;

namespace Pedidos.Application.Maps
{
    public class ProdutoMapper : Profile
    {
        public ProdutoMapper()
        {
            CreateMap<Produto, ProdutoDto>().ReverseMap();
        }
    }
}