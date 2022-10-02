using SS.Alteration.Application.Repositories;
using SS.Alteration.Domain.Entities;
using SS.Alteration.Persistence.Contexts;

namespace SS.Alteration.Persistence.Repositories
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
