using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pedidos.Domain.Entities;

namespace Pedidos.Infra.Data.Configurator
{
    public class PessoaConfigurator : BaseDomainConfigurator<Pessoa>
    {
        private PessoaConfigurator() : base(nameof(Pessoa))
        {
        }

        public override void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            base.Configure(builder);
        }
    }
}