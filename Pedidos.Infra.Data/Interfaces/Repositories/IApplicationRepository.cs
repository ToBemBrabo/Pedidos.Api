using Pedidos.Domain.Dtos.RetornoPaginado;
using Pedidos.Domain.Entities;
using Pedidos.Infra.Data.Interfaces.LifeCycleAbstraction;

namespace Pedidos.Infra.Data.Interfaces.Repositories
{
    public interface IApplicationRepository<TEntity> : IScopedDependency where TEntity : EntityBase
    {
        #region Consultas

        Task<ResultadoConsultaPaginado<TEntity>> Listar(int pagina);

        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> GetAllAsNoTracking();

        TEntity GetById(long id);

        Task<TEntity> GetByIdAsync(long id);

        TEntity GetByIdAsNoTracking(long id);

        Task<TEntity> GetByIdAsNoTrackingAsync(long id);

        #endregion Consultas

        #region Inserts

        TEntity Insert(TEntity entity);

        Task<TEntity> InsertAsync(TEntity entity);

        #endregion Inserts

        #region Updates

        TEntity Update(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);

        #endregion Updates
    }
}