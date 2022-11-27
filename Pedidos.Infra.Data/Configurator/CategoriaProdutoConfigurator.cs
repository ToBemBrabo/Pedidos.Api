using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pedidos.Domain.Entities;

namespace Pedidos.Infra.Data.Configurator
{
    public class CategoriaProdutoConfigurator : BaseDomainConfigurator<CategoriaProduto>
    {
        CategoriaProdutoConfigurator() : base(nameof(CategoriaProduto))
        {
        }

        public override void Configure(EntityTypeBuilder<CategoriaProduto> builder)
        {
            base.Configure(builder);
        }
    }
}