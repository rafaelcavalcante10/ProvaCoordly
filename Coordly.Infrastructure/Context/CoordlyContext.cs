using Coordly.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Coordly.Infrastructure.Context
{
    public class CoordlyContext : BaseContext<CoordlyContext>
    {
        public CoordlyContext(DbContextOptions<CoordlyContext> options) : base(options)
        {            
        }
        public DbSet<Produto> Produtos { get; set; }
    }
}
