using Microsoft.Extensions.DependencyInjection;
using SS.Alteration.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using SS.Alteration.Application.Repositories;
using SS.Alteration.Persistence.Repositories;

namespace SS.Alteration.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
            services.AddScoped<IAlterationFormReadRepository, AlterationFormReadRepository>();
            services.AddScoped<IAlterationFormWriteRepository, AlterationFormWriteRepository>();
        }
    }
}
