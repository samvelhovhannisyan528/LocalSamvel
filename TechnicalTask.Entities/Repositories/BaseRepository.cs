using Microsoft.EntityFrameworkCore;
using TechnicalTask.Entities.Context;
using TechnicalTask.Entities.Interfaces;

namespace TechnicalTask.Entities.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly TechnicalTaskDbContext _context;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(TechnicalTaskDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _dbSet = context.Set<T>();
        }

        public async Task<bool> AddAsync(T entity)
        {
            if (entity.Equals(null))
            {
                return false;
            }

            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteAllAsync()
        {
            var entities = await _dbSet.ToListAsync();

            if (entities.Equals(null))
            {
                return false;
            }

            _dbSet.RemoveRange(entities);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);

            if (entity.Equals(null))
            {
                return false;
            }

            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<List<T>> GetAllAsync()
        {
            var entites = await _dbSet.ToListAsync();

            return entites;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);

            return entity;
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            if (entity.Equals(null))
            {
                return false;
            }

            _dbSet.Update(entity);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
