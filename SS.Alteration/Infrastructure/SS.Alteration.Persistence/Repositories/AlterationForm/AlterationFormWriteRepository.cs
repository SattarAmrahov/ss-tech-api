using SS.Alteration.Application.Repositories;
using SS.Alteration.Domain.Entities;
using SS.Alteration.Persistence.Contexts;

namespace SS.Alteration.Persistence.Repositories
{
    public class AlterationFormWriteRepository : WriteRepository<AlterationForm>, IAlterationFormWriteRepository
    {
        public AlterationFormWriteRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
