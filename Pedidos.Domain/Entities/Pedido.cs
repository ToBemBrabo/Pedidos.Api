namespace Pedidos.Domain.Entities
{
    public class Pedido : EntityBase
    {
        public long PessoaId { get; set; }

        public Pessoa Pessoa { get; set; }

        public long VendedorId { get; set; }

        public Vendedor Vendedor { get; set; }

        public int NumeroPedido { get; set; }

        public DateTime DataPedido { get; set; } = DateTime.Now;

        public virtual ICollection<ProdutoPedido> ProdutoPedido { get; set; }
    }
}