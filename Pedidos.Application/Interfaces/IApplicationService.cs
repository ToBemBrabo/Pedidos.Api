using Pedidos.Application.Dtos;
using Pedidos.Application.Dtos.DtoEntities;
using Pedidos.Application.Services;
using Pedidos.Domain.Entities;
using Pedidos.Infra.Data.Interfaces.LifeCycleAbstraction;

namespace Pedidos.Application.Interfaces
{
    public interface IApplicationService<TEntity, TDto> : IScopedDependency
        where TEntity : EntityBase where TDto : BaseDto
    {
        Task<ResultService<TDto>> CadastrarAtualizar(TDto model);

        Task<RetornoPaginado<TDto>> Listar(int pagina, int registrosPorPagina);
    }
}