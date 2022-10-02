using SS.Alteration.Domain.Entities.Common;
using SS.Alteration.Application.Repositories;
using Microsoft.EntityFrameworkCore;
using SS.Alteration.Persistence.Contexts;

namespace SS.Alteration.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _appDbContext;

        public WriteRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public DbSet<T> Table => _appDbContext.Set<T>();

        public bool Delete(T entity)
        {
            var entityEntry = Table.Remove(entity);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> DeleteByIdAsync(Guid id)
        {
            var entity = await Table.FirstOrDefaultAsync(x => x.Id == id);
            return Delete(entity);
        }

        public async Task<T> InsertAsync(T entity)
        {
            var entityEntry = await Table.AddAsync(entity);
            return entity;
        }

        public bool Update(T entity)
        {
            var entityEntry = Table.Update(entity);
            return entityEntry.State == EntityState.Modified;
        }
        public async Task<int> SaveAsync() => await _appDbContext.SaveChangesAsync();
    }
}
