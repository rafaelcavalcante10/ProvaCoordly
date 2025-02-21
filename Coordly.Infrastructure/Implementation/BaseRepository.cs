using Coordly.Domain.RepositoryContracts;
using Coordly.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Coordly.Infrastructure.Implementation
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly CoordlyContext _context;
        public BaseRepository(CoordlyContext context)
        {
            _context = context;
        }
        public virtual void Delete(TEntity entity)
        {
            if (entity is not null)
                _context.Remove<TEntity>(entity);
            else
                throw new InvalidOperationException("Dados inválidos...");
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public virtual async Task<TEntity?> GetById(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public virtual void Insert(TEntity entity)
        {
            if (_context is not null && entity is not null)
                _context.Add<TEntity>(entity);
            else
                throw new InvalidOperationException("Dados inválidos...");
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public virtual void Update(TEntity entity)
        {
            if (_context is not null && entity is not null)
                _context.Update<TEntity>(entity);
            else
                throw new InvalidOperationException("Dados inválidos...");
        }
    }
}