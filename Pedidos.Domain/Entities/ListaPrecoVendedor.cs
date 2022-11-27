namespace Pedidos.Domain.Entities
{
    public class ListaPrecoVendedor : EntityBase
    {
        public long VendedorId { get; set; }

        public Vendedor Vendedor { get; set; }

        public long ListaPrecoId { get; set; }

        public ListaPreco ListaPreco { get; set; }
    }
}