using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pedidos.Domain.Entities;

namespace Pedidos.Infra.Data.Configurator
{
    public class VendedorConfigurator : BaseDomainConfigurator<Vendedor>
    {
        private VendedorConfigurator() : base(nameof(Vendedor))
        {
        }

        public override void Configure(EntityTypeBuilder<Vendedor> builder)
        {
            base.Configure(builder);
        }
    }
}