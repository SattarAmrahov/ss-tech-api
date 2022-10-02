using SS.Alteration.Application.Repositories;
using SS.Alteration.Domain.Entities;
using SS.Alteration.Persistence.Contexts;

namespace SS.Alteration.Persistence.Repositories
{
    public class SuitReadRepository : ReadRepository<Suit>, ISuitReadRepository
    {
        public SuitReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
