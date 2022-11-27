namespace Pedidos.Domain.Entities
{
    public class ListaPrecoProduto : EntityBase
    {
        public long ProdutoId { get; set; }

        public Produto Produto { get; set; }

        public long ListPrecoId { get; set; }

        public ListaPreco ListaPreco { get; set; }

        public decimal PrecoVenda { get; set; }

        public double PerdentualDescontoMaximo { get; set; }

        public double PercentualAcrescimoMaximo { get; set; }
    }
}