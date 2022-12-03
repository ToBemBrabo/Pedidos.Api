﻿using Pedidos.Application.src.Dtos;
using Pedidos.Application.src.Dtos.DtoEntities;
using Pedidos.Domain.Entities;

namespace Pedidos.Application.src.Interfaces
{
    public interface IPaisService : IApplicationService<Pais, PaisDto>
    {
        Task<PaisDto> LocalizarPaisPorId(long id);

        Task<RetornoPaginado<PaisDto>> LocalizarPaisPorNome(string nome, int pagina, int? registrosPorPagina);
    }
}