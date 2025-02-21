using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Coordly.Domain.Entities;

namespace Coordly.Infrastructure.EntitiesConfiguration
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(e => e.codigo);
            builder.Property(p => p.nome).IsRequired();
            builder.Property(p => p.valor).IsRequired();
            builder.Property(p => p.quantidade).IsRequired();
        }
    }
}
