using Pedidos.Domain.Entities;

namespace Pedidos.Application.Dtos.DtoEntities
{
    public class EnderecoDto : BaseDto
    {
        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string Cep { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public long CidadeId { get; set; }

        public Cidade Cidade { get; set; }
    }
}