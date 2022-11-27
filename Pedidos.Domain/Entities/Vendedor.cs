using System.ComponentModel.DataAnnotations;

namespace Pedidos.Domain.Entities
{
    public class Vendedor : EntityBase
    {
        [MaxLength(100)]
        public string Nome { get; set; }

        public long EnderecoId { get; set; }

        public Endereco Endereco { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }

        public virtual ICollection<ListaPrecoVendedor> ListaPrecoVendedor { get; set; }
    }
}