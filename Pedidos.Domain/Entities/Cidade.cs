using System.ComponentModel.DataAnnotations;

namespace Pedidos.Domain.Entities
{
    public class Cidade : EntityBase
    {
        [MaxLength(100)]
        public string Nome { get; set; }

        public long EstadoId { get; set; }

        public Estado Estado { get; set; }
    }
}