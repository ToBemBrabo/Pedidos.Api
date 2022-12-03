using System.ComponentModel.DataAnnotations;

namespace Pedidos.Domain.Entities
{
    public class Pais : EntityBase
    {
        [MaxLength(100)]
        public string Nome { get; set; }
    }
}