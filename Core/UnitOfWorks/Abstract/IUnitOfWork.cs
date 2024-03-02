using Core.Entities.Abstracts;
using Core.Repositories.Abstracts;

namespace Core.UnitOfWorks.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IRepositoryBase<TEntity> GetReadRepository<TEntity>() where TEntity : class, IEntityBase, new();
        IWriteRepository<TEntity> GetWriteRepository<TEntity>() where TEntity : class, IEntityBase, new();
        Task<int> SaveAsync();
        int Save();
    }
}
