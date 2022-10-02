using SS.Alteration.Application.Repositories;
using SS.Alteration.Domain.Entities;
using SS.Alteration.Persistence.Contexts;

namespace SS.Alteration.Persistence.Repositories
{
    public class AlterationFormReadRepository : ReadRepository<AlterationForm>, IAlterationFormReadRepository
    {
        public AlterationFormReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
