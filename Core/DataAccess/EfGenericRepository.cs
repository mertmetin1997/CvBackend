using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public abstract class EfGenericRepository<TEntity,TContext> : IGenericRepository<TEntity> 
        where TEntity : class, IEntity, new()   
        where TContext : DbContext
    {
        protected readonly TContext Context;
        protected readonly DbSet<TEntity> _dbset;

        protected EfGenericRepository(TContext context)
        {
            Context = context;
            _dbset = Context.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbset.AddAsync(entity);
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _dbset.AnyAsync(filter); 
        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? _dbset : _dbset.Where(filter);
        }

        public async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _dbset.FirstOrDefaultAsync(filter);
        }

        public void Remove(TEntity entity)
        {
            _dbset.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _dbset.Update(entity);  
        }
    }
}
