using System.ComponentModel.DataAnnotations;

namespace Pedidos.Domain.Entities
{
    public class Estado : EntityBase
    {
        [MaxLength(2)]
        public string Uf { get; set; }

        public string Descricao { get; set; }

        public long PaisId { get; set; }

        public Pais Pais { get; set; }
    }
}