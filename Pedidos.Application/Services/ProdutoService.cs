﻿using AutoMapper;
using Pedidos.Application.Dtos;
using Pedidos.Application.Dtos.DtoEntities;
using Pedidos.Application.Interfaces;
using Pedidos.Domain.Entities;
using Pedidos.Interface.Repositories;

namespace Pedidos.Application.Services
{
    public class ProdutoService : ApplicationService<Produto, ProdutoDto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository, IMapper mapper) : base(produtoRepository, mapper)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<RetornoPaginado<ProdutoDto>> BuscarProdutoPorNome(string text, int pagina, int registrosPorPagina = 0)
        {
            var upperText = text.ToUpper();

            var resultado = await _produtoRepository.BuscarProdutoPorNome(upperText, pagina, registrosPorPagina);

            return ObterRetornoPaginado(resultado);
        }

        public async Task<ProdutoDto> ObterProdutoComIncludes(long id)
            => _mapper.Map<ProdutoDto>(await _produtoRepository.ObterProdutoComIncludes(id));

        public async Task<ProdutoDto> ObterProdutoComIncludes(string codigo)
            => _mapper.Map<ProdutoDto>(await _produtoRepository.ObterProdutoComIncludes(codigo));
    }
}