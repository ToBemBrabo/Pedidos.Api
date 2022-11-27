using System.ComponentModel.DataAnnotations;

namespace Pedidos.Domain.Entities
{
    public class Endereco : EntityBase
    {
        [MaxLength(100)]
        public string Logradouro { get; set; }

        [MaxLength(80)]
        public string Bairro { get; set; }

        [MaxLength(8)]
        public string Cep { get; set; }

        [MaxLength(10)]
        public string Numero { get; set; }

        [MaxLength(150)]
        public string Complemento { get; set; }

        public long CidadeId { get; set; }

        public Cidade Cidade { get; set; }
    }
}