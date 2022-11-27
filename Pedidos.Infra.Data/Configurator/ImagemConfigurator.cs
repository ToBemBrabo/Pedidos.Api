using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pedidos.Domain.Entities;

namespace Pedidos.Infra.Data.Configurator
{
    public class ImagemConfigurator : BaseDomainConfigurator<Imagem>
    {
        private ImagemConfigurator() : base(nameof(Imagem))
        {
        }

        public override void Configure(EntityTypeBuilder<Imagem> builder)
        {
            base.Configure(builder);
        }
    }
}