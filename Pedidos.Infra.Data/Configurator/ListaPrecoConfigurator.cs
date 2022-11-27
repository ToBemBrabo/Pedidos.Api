using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pedidos.Domain.Entities;

namespace Pedidos.Infra.Data.Configurator
{
    public class ListaPrecoConfigurator : BaseDomainConfigurator<ListaPreco>
    {
        private ListaPrecoConfigurator() : base(nameof(ListaPreco))
        {
        }

        public override void Configure(EntityTypeBuilder<ListaPreco> builder)
        {
            base.Configure(builder);
        }
    }
}