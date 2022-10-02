using SS.Alteration.Application.Repositories;
using SS.Alteration.Domain.Entities;
using SS.Alteration.Persistence.Contexts;

namespace SS.Alteration.Persistence.Repositories
{
    public class OrderStatusReadRepository : ReadRepository<OrderStatus>, IOrderStatusReadRepository
    {
        public OrderStatusReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
