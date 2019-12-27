using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace StopBeingJerk.DataAccess
{
    public interface IRepository<EntityType> : IDisposable where EntityType : class
    {
        EntityType AddOrUpdate(EntityType entity);
        Task DeleteById<IdType>(IdType id);
        IQueryable<EntityType> Filter(Expression<Func<EntityType, bool>> predicate);
        IQueryable<EntityType> FilterWhen(Expression<Func<EntityType, bool>> predicate, Func<Context, bool> expressionToCheck);
        Task<EntityType> GetByIdAsync<IdType>(IdType id);
        Task<IEnumerable<EntityType>> GetListAsync<IdType>();
    }
}