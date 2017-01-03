using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EcoCardio.Repository.Abstract
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        bool Any(Expression<Func<TEntity, bool>> predicate);

        int Count(Expression<Func<TEntity, bool>> predicate);

        int Count();

        void Delete(int id);

        TEntity Find(int id);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> GetBy(Expression<Func<TEntity, bool>> predicate);

        IQueryable<TEntity> GetQueryable();

        void Insert(TEntity item);

        void Update(int id, TEntity t);
    }
}
