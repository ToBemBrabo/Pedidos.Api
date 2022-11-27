using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pedidos.Domain.Entities;

namespace Pedidos.Infra.Data.Configurator
{
    public class EstadoConfigurator : BaseDomainConfigurator<Estado>
    {
        private EstadoConfigurator() : base(nameof(Estado))
        {
        }

        public override void Configure(EntityTypeBuilder<Estado> builder)
        {
            base.Configure(builder);
        }
    }
}