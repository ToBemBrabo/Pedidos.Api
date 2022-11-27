using Microsoft.EntityFrameworkCore;
using Pedidos.Domain.Dtos.RetornoPaginado;
using Pedidos.Domain.Entities;
using Pedidos.Infra.Data.Common;
using Pedidos.Infra.Data.Interfaces.LifeCycleAbstraction;
using Pedidos.Infra.Data.Interfaces.Repositories;

namespace Pedidos.Infra.Data.Repositories
{
    public class ApplicationRepository<TEntity> : IApplicationRepository<TEntity>, IScopedDependency
        where TEntity : EntityBase
    {
        #region Fields

        protected const int registrosPorPagina = 10;
        protected readonly DbContext Context;
        protected readonly DbSet<TEntity> DbSet;

        #endregion Fields

        #region Protected Constructors

        protected ApplicationRepository(ApplicationDbContext context)
        {
            Context = context;
            DbSet = Context.Set<TEntity>();
        }

        #endregion Protected Constructors

        #region Public Methods

        public virtual IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public virtual IQueryable<TEntity> GetAllAsNoTracking()
        {
            return DbSet.AsNoTracking();
        }

        public virtual TEntity GetById(long id)
        {
            return DbSet.FirstOrDefault(x => x.Id == id);
        }

        public virtual TEntity GetByIdAsNoTracking(long id)
        {
            return DbSet.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public virtual async Task<TEntity> GetByIdAsNoTrackingAsync(long id)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public virtual async Task<TEntity> GetByIdAsync(long id)
        {
            return await DbSet.FirstOrDefaultAsync(x => x.Id == id);
        }

        public TEntity Insert(TEntity entity)
        {
            Context.Add(entity);

            Context.SaveChanges();

            return entity;
        }

        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            Context.Add(entity);

            await Context.SaveChangesAsync();

            return entity;
        }

        public async Task<ResultadoConsultaPaginado<TEntity>> Listar(int pagina)
        {
            var result = GetAll()
                .OrderBy(x => x.Id);

            return await GetReturnPagineted(pagina, result);
        }

        public TEntity Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        #endregion Public Methods

        #region Protected Methods

        protected async Task<ResultadoConsultaPaginado<TEntity>> GetReturnPagineted(int pagina, IOrderedQueryable<TEntity> result)
        {
            var resultPagineted = await result.Skip(ObterQuantidadeDeRegistrosAListar(pagina))
                    .Take(registrosPorPagina).ToListAsync();

            return new ResultadoConsultaPaginado<TEntity>
            {
                PaginaAtual = pagina,
                TotalDePaginas = result.Count() / registrosPorPagina,
                Retorno = resultPagineted,
            };
        }

        protected int ObterQuantidadeDeRegistrosAListar(int pagina)
        {
            return registrosPorPagina * pagina;
        }

        #endregion Protected Methods
    }
}