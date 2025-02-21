using Coordly.Domain.Entities;
using Coordly.Domain.RepositoryContracts;
using Coordly.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Coordly.Infrastructure.Implementation
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(CoordlyContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Produto>> GetByName(string produto)
        {
            return await _context.Produtos.Where(w => w.nome.Contains(produto)).ToListAsync();
        }
    }
}
