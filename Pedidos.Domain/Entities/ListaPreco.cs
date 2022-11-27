using System.ComponentModel.DataAnnotations;

namespace Pedidos.Domain.Entities
{
    public class ListaPreco : EntityBase
    {
        [MaxLength(50)]
        public string Descricao { get; set; }

        public virtual ICollection<ListaPrecoProduto> ListaPrecoProdutos { get; set; }
    }
}