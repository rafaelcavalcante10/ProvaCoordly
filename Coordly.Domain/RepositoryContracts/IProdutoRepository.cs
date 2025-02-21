using Coordly.Domain.Entities;

namespace Coordly.Domain.RepositoryContracts
{
    public interface IProdutoRepository : IBaseRepository<Produto>
    {
        Task<IEnumerable<Produto>> GetByName(string produto);
    }
}
