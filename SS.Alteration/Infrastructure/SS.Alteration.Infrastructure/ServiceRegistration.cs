using Microsoft.Azure.ServiceBus;
using Microsoft.Extensions.DependencyInjection;
using SS.Alteration.Application.Services;
using SS.Alteration.Infrastructure.Services;

namespace SS.Alteration.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IMessagePublisher, MessagePublisher>();
            services.AddSingleton<ITopicClient>(x => new TopicClient(Configuration.ServiceBusConfig.ConnectionString, Configuration.ServiceBusConfig.TopicName));

            services.AddSingleton<ISubscriptionClient>(x => new SubscriptionClient(Configuration.ServiceBusConfig.ConnectionString, Configuration.ServiceBusConfig.TopicName, Configuration.ServiceBusConfig.SubscriptionName));
        }
    }
}
