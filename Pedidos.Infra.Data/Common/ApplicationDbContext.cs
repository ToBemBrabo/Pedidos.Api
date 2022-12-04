using Microsoft.EntityFrameworkCore;
using Pedidos.Domain.Entities;

namespace Pedidos.Infra.Data.Common
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Pais> Pais { get; set; }

        public DbSet<Estado> Estado { get; set; }

        public DbSet<Cidade> Cidade { get; set; }

        public DbSet<Endereco> Endereco { get; set; }

        public DbSet<Pessoa> Pessoa { get; set; }

        public DbSet<Vendedor> Vendedor { get; set; }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<CategoriaProduto> CategoriaProduto { get; set; }

        public DbSet<ListaPreco> ListaPreco { get; set; }

        public DbSet<ListaPrecoProduto> ListaPrecoProduto { get; set; }

        public DbSet<Pedido> Pedido { get; set; }

        public DbSet<ProdutoPedido> ProdutoPedido { get; set; }

        public DbSet<ListaPrecoVendedor> ListaPrecoVendedor { get; set; }

        public ApplicationDbContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = true;
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}