namespace Pedidos.Domain.Entities
{
    public class ProdutoPedido : EntityBase
    {
        public long ProdutoId { get; set; }

        public Produto Produto { get; set; }

        public double Quantidade { get; set; }

        public decimal PrecoVenda { get; set; }

        public double DescontoPraticado { get; set; }

        public long? ListaPrecoId { get; set; }

        public ListaPreco? ListaPreco { get; set; }
    }
}