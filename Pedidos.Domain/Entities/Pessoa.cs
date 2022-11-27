using Pedidos.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Pedidos.Domain.Entities
{
    public class Pessoa : EntityBase
    {
        [MaxLength(100)]
        public string Nome { get; set; }

        public TipoPessoaEnum TipoPessoa { get; set; }

        [MaxLength(11)]
        public string Cpf { get; set; }

        [MaxLength(14)]
        public string InscricaoFederal { get; set; }

        public long EnderecoId { get; set; }

        public Endereco Endereco { get; set; }
    }
}