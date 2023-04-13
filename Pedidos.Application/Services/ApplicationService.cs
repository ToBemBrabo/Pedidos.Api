using AutoMapper;
using Pedidos.Application.Dtos;
using Pedidos.Application.Dtos.DtoEntities;
using Pedidos.Application.Exceptions;
using Pedidos.Application.Interfaces;
using Pedidos.Domain.Dtos.RetornoPaginado;
using Pedidos.Domain.Entities;
using Pedidos.Infra.Data.Interfaces.Repositories;

namespace Pedidos.Application.Services
{
    public class ApplicationService<TEntity, TDto> : IApplicationService<TEntity, TDto>
        where TEntity : EntityBase where TDto : BaseDto
    {
        #region Fields

        protected readonly IMapper _mapper;
        protected readonly IApplicationRepository<TEntity> _repository;

        #endregion Fields

        #region Public Constructors

        public ApplicationService(IApplicationRepository<TEntity> repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        #endregion Public Constructors

        #region Public Methods

        public virtual async Task<ResultService<TDto>> CadastrarAtualizar(TDto model)
        {
            try
            {
                var entity = _mapper.Map<TEntity>(model);

                if (entity.Id > 0L)
                    return await AtualizarCadastro(entity);

                return await Cadastrar(entity);
            }
            catch (Exception ex)
            {
                return ResultService.Fail<TDto>(ex.Message);
            }
        }

        public async Task<RetornoPaginado<TDto>> Listar(int pagina, int registrosPorPagina)
        {
            var list = await _repository.Listar(pagina, registrosPorPagina);

            return ObterRetornoPaginado(list);
        }

        #endregion Public Methods

        #region Protected Methods

        protected async Task InsertAsync(TEntity entity)
        {
            try
            {
                await _repository.InsertAsync(entity);
            }
            catch (Exception ex)
            {
                throw new InsertOrUpdateException(ex.Message);
            }
        }

        protected RetornoPaginado<TDto> ObterRetornoPaginado(ResultadoConsultaPaginado<TEntity> list)
        {
            return new RetornoPaginado<TDto>
            {
                PaginaAtual = list.PaginaAtual,
                TotalDePaginas = list.TotalDePaginas,
                Retorno = _mapper.ProjectTo<TDto>(list.Retorno.AsQueryable()),
            };
        }

        #endregion Protected Methods

        #region Private Methods

        private async Task<ResultService<TDto>> AtualizarCadastro(TEntity entity)
        {
            await UpdateAsync(entity);

            return ResultService.Ok(_mapper.Map<TDto>(entity));
        }

        private async Task<ResultService<TDto>> Cadastrar(TEntity entity)
        {
            await InsertAsync(entity);

            return ResultService.Ok(_mapper.Map<TDto>(entity));
        }

        private async Task UpdateAsync(TEntity entity)
        {
            try
            {
                await _repository.UpdateAsync(entity);
            }
            catch (Exception ex)
            {
                throw new InsertOrUpdateException(ex.Message);
            }
        }

        #endregion Private Methods
    }
}