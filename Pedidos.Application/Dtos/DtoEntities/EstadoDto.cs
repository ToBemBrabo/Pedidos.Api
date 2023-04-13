namespace Pedidos.Application.Dtos.DtoEntities
{
    public class EstadoDto : BaseDto
    {
        public string Uf { get; set; }

        public string Descricao { get; set; }

        public long PaisId { get; set; }
    }
}