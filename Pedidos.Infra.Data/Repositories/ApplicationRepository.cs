﻿using Microsoft.EntityFrameworkCore;
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

        protected readonly DbContext Context;
        protected readonly DbSet<TEntity> DbSet;

        protected const int maxRegistrosPorPagina = 200;
        protected int RegistrosPorPagina = 10;

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

        public async Task<ResultadoConsultaPaginado<TEntity>> Listar(int pagina, int registrosPorPagina)
        {
            var result = GetAll()
                .OrderBy(x => x.Id);

            return await GetReturnPagineted(result, pagina, registrosPorPagina);
        }

        public TEntity Update(TEntity entity)
        {
            Context.Update(entity);

            Context.SaveChanges();

            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            Context.Update(entity);

            await Context.SaveChangesAsync();

            return entity;
        }

        #endregion Public Methods

        #region Protected Methods

        protected async Task<ResultadoConsultaPaginado<TEntity>> GetReturnPagineted(IOrderedQueryable<TEntity> result, int pagina, int? registrosPorPagina)
        {
            SetNumberOfResults(registrosPorPagina);

            var paginetedResult = await result
                .Skip(ObterQuantidadeDeRegistrosAListar(pagina))
                .Take(RegistrosPorPagina).ToListAsync();

            return new ResultadoConsultaPaginado<TEntity>
            {
                PaginaAtual = pagina,
                TotalDePaginas = result.Count() / RegistrosPorPagina,
                Retorno = paginetedResult,
            };
        }

        protected int ObterQuantidadeDeRegistrosAListar(int pagina)
        {
            return RegistrosPorPagina * pagina;
        }

        #endregion Protected Methods

        #region Private Methods

        private void SetNumberOfResults(int? registrosPorPagina)
        {
            if (registrosPorPagina != null && registrosPorPagina > RegistrosPorPagina)
            {
                if (registrosPorPagina < maxRegistrosPorPagina)
                    RegistrosPorPagina = registrosPorPagina.Value;
                else
                    RegistrosPorPagina = maxRegistrosPorPagina;
            }
        }

        #endregion Private Methods
    }
}