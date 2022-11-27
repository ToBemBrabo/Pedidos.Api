using Pedidos.Domain.Entities;

namespace Pedidos.Domain.Dtos.RetornoPaginado
{
    public class ResultadoConsultaPaginado<TEntity> where TEntity : EntityBase
    {
        public int PaginaAtual { get; set; }

        public int TotalDePaginas { get; set; }

        public string Paginacao { get => $"Página {PaginaAtual}/{TotalDePaginas}"; }

        public IEnumerable<TEntity> Retorno { get; set; }
    }
}