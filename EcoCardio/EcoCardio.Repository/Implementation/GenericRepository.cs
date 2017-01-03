using EcoCardio.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace EcoCardio.Repository.Implementation
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private EcoCardioContext _context;
        private DbSet<TEntity> _dbSet;

        public GenericRepository(EcoCardioContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public bool Any(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Any(predicate);
        }

        public int Count()
        {
            return _dbSet.Count();
        }

        public int Count(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Count(predicate);
        }

        public void Delete(int id)
        {
            var item = _dbSet.Find(id);
            _dbSet.Remove(item);
        }

        public TEntity Find(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public IEnumerable<TEntity> GetBy(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.AsNoTracking().Where(predicate).ToList();
        }

        public IQueryable<TEntity> GetQueryable()
        {
            return _dbSet.AsNoTracking();
        }

        public void Insert(TEntity item)
        {
            _dbSet.Add(item);
        }

        public void Update(int id, TEntity t)
        {
            _dbSet.Attach(t);
            _context.Entry(t).State = EntityState.Modified;
        }
    }
}
