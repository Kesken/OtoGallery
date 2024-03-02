using Core.Entities.Abstracts;
using Core.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Core.Repositories.Concretes
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class, IEntityBase, new()
    {
        private readonly DbContext _dbContext;

        public RepositoryBase(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        private DbSet<TEntity> Table { get => _dbContext.Set<TEntity>(); }

        public async Task<IList<TEntity>> GetAllAsync(
            Expression<Func<TEntity, bool>>? filter = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
            bool enableTracking = false)
        {
            IQueryable<TEntity> queryable = Table;

            if (enableTracking is not true)
                queryable = queryable.AsNoTracking();

            if (include is not null)
                queryable = include(queryable);

            if (filter is not null)
                queryable.Where(filter);

            if (orderBy is not null)
                return await orderBy(queryable).ToListAsync();

            return await queryable.ToListAsync();
        }

        public async Task<TEntity> GetAsync(
            Expression<Func<TEntity, bool>>? filter,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
            bool enableTracking = false)
        {
            IQueryable<TEntity> queryable = Table;

            if (enableTracking is not true)
                queryable = queryable.AsNoTracking();

            if (include is not null)
                queryable = include(queryable);

            return await queryable.FirstOrDefaultAsync(filter);
        }

        public IQueryable<TEntity> Find(
            Expression<Func<TEntity, bool>> filter,
            bool enableTracking = false)
        {
            if (enableTracking is not true)
                Table.AsNoTracking();

            return Table.Where(filter);
        }


        public async Task AddAsync(TEntity entity)
        {
            await Table.AddAsync(entity);
        }
        public async Task AddRangeAsync(IList<TEntity> entities)
        {
            await Table.AddRangeAsync(entities);
        }
        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            await Task.Run(
            () =>
            {
                Table.Update(entity);
            });
            return entity;
        }
        public async Task HardDeleteAsync(TEntity entity)
        {
            await Task.Run(
                () => Table.Remove(entity));
        }
        public async Task HardDeleteRangeAsync(IList<TEntity> entities) => await Task.Run(() => Table.RemoveRange(entities));
    }
}
