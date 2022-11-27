using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pedidos.Domain.Entities;

namespace Pedidos.Infra.Data.Configurator
{
    public class CidadeConfigurator : BaseDomainConfigurator<Cidade>
    {
        CidadeConfigurator() : base(nameof(Cidade))
        {
        }

        public override void Configure(EntityTypeBuilder<Cidade> builder)
        {
            base.Configure(builder);
        }
    }
}