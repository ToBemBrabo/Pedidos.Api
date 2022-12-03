using Pedidos.Domain.Entities;

namespace Pedidos.Domain.Seeds
{
    public class PaisSeed
    {
        public static ICollection<Pais> GetList()
        {
            return new List<Pais>
            {
                new Pais { Id = 1, Nome = "Brasil" },
            };
        }
    }
}