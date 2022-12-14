using Microsoft.EntityFrameworkCore;
using SS.Alteration.Domain.Entities;
using SS.Alteration.Domain.Entities.Common;
using SS.Alteration.Domain.Enums;

namespace SS.Alteration.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AlterationForm> AlterationForms { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Instruction> Instructions { get; set; }
        public DbSet<Suit> Suits { get; set; }
        public DbSet<Order> Orders { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderStatus>().HasData(
                new OrderStatus
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    Name = EAlterationStatus.Received.ToString()
                },
                new OrderStatus
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    Name = EAlterationStatus.InProgress.ToString()
                }, 
                new OrderStatus
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    Name = EAlterationStatus.Ready.ToString()
                }
            );
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var item in datas)
            {
                _ = item.State switch
                {
                    EntityState.Added => item.Entity.CreatedAt = DateTime.UtcNow,
                    EntityState.Modified => item.Entity.UpdatedAt = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
