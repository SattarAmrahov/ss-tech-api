using Microsoft.EntityFrameworkCore;
using SS.Alteration.Application.Repositories;
using SS.Alteration.Domain.Entities;
using SS.Alteration.Persistence.Contexts;

namespace SS.Alteration.Persistence.Repositories
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

      
    }
}
