using AutoMapper;
using Pedidos.Application.src.Dtos;
using Pedidos.Application.src.Dtos.DtoEntities;
using Pedidos.Application.src.Exceptions;
using Pedidos.Application.src.Interfaces;
using Pedidos.Application.src.Services;
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

        public virtual async Task<ResultService<TDto>> Cadastrar(TDto model)
        {
            try
            {
                var entity = _mapper.Map<TEntity>(model);

                await InsertAsync(entity);

                return ResultService.Ok(_mapper.Map<TDto>(model));
            }
            catch (Exception ex)
            {
                return ResultService.Fail<TDto>(ex.Message);
            }
        }

        public async Task<RetornoPaginado<TDto>> Listar(int pagina)
        {
            var list = await _repository.Listar(pagina);

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
            catch
            {
                throw new InsertException();
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
    }
}