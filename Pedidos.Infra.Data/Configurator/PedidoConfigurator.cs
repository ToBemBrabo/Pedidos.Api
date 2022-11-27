using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pedidos.Domain.Entities;

namespace Pedidos.Infra.Data.Configurator
{
    public class PedidoConfigurator : BaseDomainConfigurator<Pedido>
    {
        private PedidoConfigurator() : base(nameof(Pedido))
        {
        }

        public override void Configure(EntityTypeBuilder<Pedido> builder)
        {
            base.Configure(builder);
        }
    }
}