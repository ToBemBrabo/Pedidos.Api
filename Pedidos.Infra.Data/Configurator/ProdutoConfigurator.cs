using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pedidos.Domain.Entities;

namespace Pedidos.Infra.Data.Configurator
{
    public class ProdutoConfigurator : BaseDomainConfigurator<Produto>
    {
        private ProdutoConfigurator() : base(nameof(Produto))
        {
        }

        public override void Configure(EntityTypeBuilder<Produto> builder)
        {
            base.Configure(builder);
        }
    }
}