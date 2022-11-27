using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pedidos.Domain.Entities;

namespace Pedidos.Infra.Data.Configurator
{
    public class ProdutoPedidoConfigurator : BaseDomainConfigurator<ProdutoPedido>
    {
        private ProdutoPedidoConfigurator() : base(nameof(ProdutoPedido))
        {
        }

        public override void Configure(EntityTypeBuilder<ProdutoPedido> builder)
        {
            base.Configure(builder);
        }
    }
}