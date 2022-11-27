using Pedidos.Domain.Entities;
using Pedidos.Domain.Enums;

namespace Pedidos.Application.src.Dtos.DtoEntities
{
    public class PessoaDto : BaseDto
    {
        public string Nome { get; set; }

        public TipoPessoaEnum TipoPessoa { get; set; }

        public string Cpf { get; set; }

        public string InscricaoFederal { get; set; }

        public long EnderecoId { get; set; }

        public Endereco Endereco { get; set; }
    }
}