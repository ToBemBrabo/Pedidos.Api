using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pedidos.Domain.Entities;

namespace Pedidos.Infra.Data.Configurator
{
    public class ListaPrecoProdutoConfigurator : BaseDomainConfigurator<ListaPrecoProduto>
    {
        private ListaPrecoProdutoConfigurator() : base(nameof(ListaPrecoProduto))
        {
        }

        public override void Configure(EntityTypeBuilder<ListaPrecoProduto> builder)
        {
            base.Configure(builder);
        }
    }
}