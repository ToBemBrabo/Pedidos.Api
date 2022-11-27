using System.ComponentModel.DataAnnotations;

namespace Pedidos.Domain.Entities
{
    public class CategoriaProduto : EntityBase
    {
        [MaxLength(100)]
        public string Descricao { get; set; }
    }
}