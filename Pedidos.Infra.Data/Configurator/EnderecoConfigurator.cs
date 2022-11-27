using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pedidos.Domain.Entities;

namespace Pedidos.Infra.Data.Configurator
{
    public class EnderecoConfigurator : BaseDomainConfigurator<Endereco>
    {
        private EnderecoConfigurator() : base(nameof(Endereco))
        {
        }

        public override void Configure(EntityTypeBuilder<Endereco> builder)
        {
            base.Configure(builder);
        }
    }
}