using System.ComponentModel.DataAnnotations;

namespace Pedidos.Domain.Entities
{
    public class Imagem : EntityBase
    {
        [MaxLength(40)]
        public string Nome { get; set; }

        public string NomeArquivo { get; set; }

        public bool Principal { get; set; }
    }
}