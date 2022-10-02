using Microsoft.EntityFrameworkCore;
using SS.Alteration.Domain.Entities.Common;

namespace SS.Alteration.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
