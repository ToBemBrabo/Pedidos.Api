using Pedidos.Domain.Entities;

namespace Pedidos.Domain.Seeds
{
    public class EstadoSeed
    {
        public static ICollection<Estado> GetList()
        {
            return new List<Estado>
            {
                new Estado {Id = 1, PaisId= 1, Descricao = "Acre", Uf = "AC" },
                new Estado {Id = 2, PaisId= 1, Descricao = "Alagoas", Uf = "AL" },
                new Estado {Id = 3, PaisId= 1, Descricao = "Amapá", Uf = "AP" },
                new Estado {Id = 4, PaisId= 1, Descricao = "Amazonas", Uf = "AM" },
                new Estado {Id = 5, PaisId= 1, Descricao = "Bahia", Uf = "BA" },
                new Estado {Id = 6, PaisId= 1, Descricao = "Ceara", Uf = "CE" },
                new Estado {Id = 7, PaisId= 1, Descricao = "Distrito Federal", Uf = "DF" },
                new Estado {Id = 8, PaisId= 1, Descricao = "Espirito Santo", Uf = "ES" },
                new Estado {Id = 9, PaisId= 1, Descricao = "Goiás", Uf = "GO" },
                new Estado {Id = 10, PaisId= 1, Descricao = "Maranhão", Uf = "MA" },
                new Estado {Id = 11, PaisId= 1, Descricao = "Mato Grosso", Uf = "MT" },
                new Estado {Id = 12, PaisId= 1, Descricao = "Mato Grosso do Sul", Uf = "MS" },
                new Estado {Id = 13, PaisId= 1, Descricao = "Minas Gerais", Uf = "MG" },
                new Estado {Id = 14, PaisId= 1, Descricao = "Para", Uf = "PA" },
                new Estado {Id = 15, PaisId= 1, Descricao = "Paraíba", Uf = "PB" },
                new Estado {Id = 16, PaisId= 1, Descricao = "Paraná", Uf = "PR" },
                new Estado {Id = 17, PaisId= 1, Descricao = "Pernambuco", Uf = "PE" },
                new Estado {Id = 18, PaisId= 1, Descricao = "Piauí", Uf = "PI" },
                new Estado {Id = 19, PaisId= 1, Descricao = "Rio de Janeiro", Uf = "RJ" },
                new Estado {Id = 20, PaisId= 1, Descricao = "Rio Grande do Norte", Uf = "RN" },
                new Estado {Id = 21, PaisId= 1, Descricao = "Rio Grande do Sul", Uf = "RS" },
                new Estado {Id = 22, PaisId= 1, Descricao = "Rondônia", Uf = "RO" },
                new Estado {Id = 23, PaisId= 1, Descricao = "Roraima", Uf = "RR" },
                new Estado {Id = 24, PaisId= 1, Descricao = "Santa Catarina", Uf = "SC" },
                new Estado {Id = 25, PaisId= 1, Descricao = "São Paulo", Uf = "SP" },
                new Estado {Id = 26, PaisId= 1, Descricao = "Sergipe", Uf = "SE" },
                new Estado {Id = 27, PaisId= 1, Descricao = "Tocantins", Uf = "TO" },
            };
        }
    }
}