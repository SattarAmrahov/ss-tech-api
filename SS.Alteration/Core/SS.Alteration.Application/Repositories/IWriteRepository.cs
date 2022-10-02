using SS.Alteration.Domain.Entities.Common;

namespace SS.Alteration.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> InsertAsync(T entity);
        bool Delete(T entity);
        Task<bool> DeleteByIdAsync(Guid id);
        bool Update(T entity);

        Task<int> SaveAsync();
    }
}
