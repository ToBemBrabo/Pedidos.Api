using Microsoft.EntityFrameworkCore;
using Pedidos.Domain.Entities;
using Pedidos.Domain.Seeds;
using Pedidos.Infra.Data.Interfaces.LifeCycleAbstraction;

namespace Pedidos.Infra.Data.Common
{
    public class SeedingService : IScopedDependency
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pais>().HasData(PaisSeed.GetList());
            modelBuilder.Entity<Estado>().HasData(EstadoSeed.GetList());
        }
    }
}