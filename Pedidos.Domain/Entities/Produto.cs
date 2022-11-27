using System.ComponentModel.DataAnnotations;

namespace Pedidos.Domain.Entities
{
    public class Produto : EntityBase
    {
        [MaxLength(100)]
        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public string Codigo { get; set; }

        public long CategoriaId { get; set; }

        public CategoriaProduto Categoria { get; set; }

        public List<Imagem> Imagens { get; set; }

        public virtual ICollection<ProdutoPedido> ProdutosPedidos { get; set; }

        public virtual ICollection<ListaPrecoProduto> ListaPrecoProduto { get; set; }
    }
}