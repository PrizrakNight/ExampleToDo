using ExampleToDo.Application.Interfaces.DataAccess;
using ExampleToDo.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleToDo.Persistence.EFCore.Implementation
{
    public class DbSetRepository<TEntity> : IApplicationRepository<TEntity>
        where TEntity : class, IDomainEntity
    {
        private readonly DbSet<TEntity> _entities;
        private readonly Func<DbSet<TEntity>, IQueryable<TEntity>> _include;

        public DbSetRepository(DbSet<TEntity> entities, Func<DbSet<TEntity>, IQueryable<TEntity>> include = default)
        {
            _entities = entities;
            _include = include;
        }

        public Task<bool> DeleteAsync(TEntity entity) => Task<bool>.Factory.StartNew(() =>
        {
            return _entities.Remove(entity).State == EntityState.Deleted;
        });

        public Task<TEntity> FindAsync(int entityId) => Task<TEntity>.Factory.StartNew(() =>
        {
            return GetQuery().SingleOrDefault(entity => entity.Id == entityId);
        });

        public Task<TEntity[]> Get(Func<TEntity, bool> predicate = null) => Task<TEntity[]>.Factory.StartNew(() =>
        {
            if (predicate != default)
                return GetQuery().Where(predicate).ToArray();

            return GetQuery().ToArray();
        });

        public Task<bool> InsertAsync(TEntity entity) => Task<bool>.Factory.StartNew(() =>
        {
            return _entities.Add(entity).State == EntityState.Added;
        });

        public Task<bool> UpdateAsync(TEntity entity) => Task<bool>.Factory.StartNew(() =>
        {
            return _entities.Update(entity).State == EntityState.Modified;
        });

        private IQueryable<TEntity> GetQuery() => _include != default ? _include.Invoke(_entities) : _entities.AsQueryable();
    }
}
