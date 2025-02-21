using Coordly.Infrastructure.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Coordly.Infrastructure.Context
{
    public class BaseContext<TContext> : DbContext where TContext : DbContext
    {
        public BaseContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProdutoConfiguration).Assembly);
        }
    }
}
