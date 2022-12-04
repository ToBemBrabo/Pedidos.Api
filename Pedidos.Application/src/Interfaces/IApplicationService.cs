using Pedidos.Application.src.Dtos;
using Pedidos.Application.src.Dtos.DtoEntities;
using Pedidos.Application.src.Services;
using Pedidos.Domain.Entities;
using Pedidos.Infra.Data.Interfaces.LifeCycleAbstraction;

namespace Pedidos.Application.src.Interfaces
{
    public interface IApplicationService<TEntity, TDto> : IScopedDependency
        where TEntity : EntityBase where TDto : BaseDto
    {
        Task<ResultService<TDto>> CadastrarAtualizar(TDto model);

        Task<RetornoPaginado<TDto>> Listar(int pagina, int registrosPorPagina);
    }
}