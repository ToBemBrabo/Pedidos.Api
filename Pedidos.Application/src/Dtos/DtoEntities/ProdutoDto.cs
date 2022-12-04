using Pedidos.Domain.Entities;

namespace Pedidos.Application.src.Dtos.DtoEntities
{
    public class ProdutoDto : BaseDto
    {
        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public string Codigo { get; set; }

        public long CategoriaId { get; set; }

        public CategoriaProduto Categoria { get; set; }
    }
}