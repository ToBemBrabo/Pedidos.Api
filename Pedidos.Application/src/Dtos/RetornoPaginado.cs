﻿using Pedidos.Application.src.Dtos.DtoEntities;

namespace Pedidos.Application.src.Dtos
{
    public class RetornoPaginado<TDto> where TDto : BaseDto
    {
        public int PaginaAtual { get; set; }

        public int TotalDePaginas { get; set; }

        public string Paginacao { get => $"Página {PaginaAtual}/{TotalDePaginas}"; }

        public IEnumerable<TDto> Retorno { get; set; }
    }
}