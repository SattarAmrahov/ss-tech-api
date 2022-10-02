using SS.Alteration.Application.Repositories;
using SS.Alteration.Domain.Entities;
using SS.Alteration.Persistence.Contexts;

namespace SS.Alteration.Persistence.Repositories
{
    public class SuitWriteRepository : WriteRepository<Suit>, ISuitWriteRepository
    {
        public SuitWriteRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
