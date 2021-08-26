using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApiProjectX.Infra.Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly ProjectXContext _dbContext;

        public BaseRepository(ProjectXContext context)
        {
            _dbContext = context;
        }
        public async virtual Task<T> Create(T entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;

            EntityEntry<T> retorno = await _dbContext.Set<T>().AddAsync(entity);
            return retorno.Entity;
        }

        public async virtual Task CreateMany(IEnumerable<T> entities)
        {
            await _dbContext.Set<T>().AddRangeAsync(entities);
        }

        public virtual void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public virtual void DeleteMany(IEnumerable<T> entities)
        {
            _dbContext.Set<T>().RemoveRange(entities);

            _dbContext.SaveChanges();
        }

        public virtual async Task<bool> Exists(object id)
        {
            T entity = await _dbContext.Set<T>().FindAsync(id);
            return entity != null;
        }

        public virtual async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression, int? skip = null, int? take = null, IEnumerable<string> includes = null)
        {
            var query = await _dbContext.Set<T>().Where(expression).ToListAsync();

            if (skip.HasValue)
            {
                query = query.Skip(skip.Value).ToList();
            }

            if (take.HasValue)
            {
                query = query.Take(take.Value).ToList();
            }

            return LoadDependencies(query, includes);
        }

        public virtual async Task<IEnumerable<T>> FindAll(IEnumerable<string> includes = null)
        {
            var query = await _dbContext.Set<T>().Where(x => true).ToListAsync();

            return LoadDependencies(query, includes);
        }

        public virtual async Task<T> FindById(Guid id, IEnumerable<string> includes = null)
        {
            return await FindSingle(entity => entity.Id == id, includes: includes);
        }

        public virtual async Task<T> FindSingle(Expression<Func<T, bool>> expression, IEnumerable<string> includes = null)
        {
            var query = _dbContext.Set<T>().Where(expression);

            return await LoadDependencies(query, includes);
        }

        public virtual async Task Save()
        {
            await _dbContext.SaveChangesAsync();
        }

        public virtual async Task Update(T entity)
        {
            entity.UpdatedAt = DateTime.Now;
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        private async Task<T> LoadDependencies(IQueryable<T> query, IEnumerable<string> includes)
        {
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }

            return await query.FirstOrDefaultAsync();
        }
        private ICollection<T> LoadDependencies(ICollection<T> query, IEnumerable<string> includes)
        {
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.AsQueryable().Include(include).ToList();
                }
            }

            return query;
        }
    }
}
