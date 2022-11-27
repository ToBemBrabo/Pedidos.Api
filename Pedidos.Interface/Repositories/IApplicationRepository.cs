using Pedidos.Domain.Dtos.RetornoPaginado;
using Pedidos.Domain.Entities;
using Pedidos.Interface.LifeCycleAbstraction;

namespace Pedidos.Interface.Repositories
{
    public interface IApplicationRepository<TEntity> : IScopedDependency where TEntity : EntityBase
    {
        Task<RetornoPaginado<TEntity>> Listar(int pagina);

        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> GetAllAsNoTracking();

        TEntity GetById(long id);

        Task<TEntity> GetByIdAsync(long id);

        TEntity GetByIdAsNoTracking(long id);

        Task<TEntity> GetByIdAsNoTrackingAsync(long id);
    }
}