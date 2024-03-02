using Core.Entities.Abstracts;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Core.Repositories.Abstracts
{
    public interface IRepositoryBase<TEntity> where TEntity : class, IEntityBase, new()
    {
        Task<IList<TEntity>> GetAllAsync(
            Expression<Func<TEntity, bool>>? filter = null, // Linq sorugularını yazabilmek için.
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, // Include edebilmeyi sagliyor.
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, // Getirdigin listeyi belli bir kosula gore siralamak istersen.
            bool enableTracking = false);

        Task<TEntity> GetAsync(
            Expression<Func<TEntity, bool>>? filter,// Linq sorugularını yazabilmek için.
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,// Include edebilmeyi sagliyor.
            bool enableTracking = false);

        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, bool enableTracking = false);

        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IList<TEntity> entities);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task HardDeleteAsync(TEntity entity);
        Task HardDeleteRangeAsync(IList<TEntity> entities);
    }
}
