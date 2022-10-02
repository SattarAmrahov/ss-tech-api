using SS.Alteration.Domain.Entities.Common;
using System.Linq.Expressions;

namespace SS.Alteration.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll(bool tracking = true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool tracking = true);
        Task<T> GetById(Guid id, bool tracking = true);
    }
}
