using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace StopBeingJerk.DataAccess
{
    public class Repository<EntityType> : IRepository<EntityType> where EntityType : class
    {
        // TODO: add transaction scope
        private readonly Context _context;
        private bool _isDisposed = false;
        public DbSet<EntityType> Set => _context.Set<EntityType>();

        public Repository(Context context)
        {
            _context = context;
        }

        public async Task<EntityType> GetByIdAsync<IdType>(IdType id)
        {
            return await _context.Set<EntityType>().FindAsync(id);
        }

        public async Task<IEnumerable<EntityType>> GetListAsync<IdType>()
        {
            return await _context.Set<EntityType>().ToListAsync();
        }

        public IQueryable<EntityType> Filter(Expression<Func<EntityType, bool>> predicate)
        {
            return _context.Set<EntityType>().Where(predicate);
        }

        public IQueryable<EntityType> FilterWhen(Expression<Func<EntityType, bool>> predicate, Func<Context, bool> expressionToCheck)
        {
            if (expressionToCheck(_context))
                return _context.Set<EntityType>().Where(predicate);

            return Enumerable.Empty<EntityType>().AsQueryable();
        }

        public async Task DeleteById<IdType>(IdType id)
        {
            var entityToDelete = await GetByIdAsync(id);

            _context.Set<EntityType>().Remove(entityToDelete);

            await _context.SaveChangesAsync();
        }

        public async Task<EntityType> AddOrUpdate(EntityType entity)
        {
            var result = _context.Set<EntityType>().Update(entity).Entity;

            await _context.SaveChangesAsync();

            return result;
        }

        public void Dispose()
        {
            if (_isDisposed) return;

            _isDisposed = true;

            _context.Dispose();
        }
    }
}
