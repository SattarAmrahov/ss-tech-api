using SS.Alteration.Application.Repositories;
using SS.Alteration.Domain.Entities;
using SS.Alteration.Persistence.Contexts;

namespace SS.Alteration.Persistence.Repositories
{
    public class OrderStatusWriteRepository : WriteRepository<OrderStatus>, IOrderStatusWriteRepository
    {
        public OrderStatusWriteRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
