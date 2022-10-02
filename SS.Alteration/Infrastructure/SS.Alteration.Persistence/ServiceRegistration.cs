using Microsoft.Extensions.DependencyInjection;
using SS.Alteration.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using SS.Alteration.Application.Repositories;
using SS.Alteration.Persistence.Repositories;
using SS.Alteration.Application.Services;
using SS.Alteration.Persistence.Services;

namespace SS.Alteration.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
            services.AddScoped<IAlterationFormReadRepository, AlterationFormReadRepository>();
            services.AddScoped<IAlterationFormWriteRepository, AlterationFormWriteRepository>();
            services.AddScoped<IOrderStatusReadRepository, OrderStatusReadRepository>();
            services.AddScoped<IOrderStatusWriteRepository, OrderStatusWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<ISuitReadRepository, SuitReadRepository>();
            services.AddScoped<ISuitWriteRepository, SuitWriteRepository>();

            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderStatusService, OrderStatusService>();
        }
    }
}
