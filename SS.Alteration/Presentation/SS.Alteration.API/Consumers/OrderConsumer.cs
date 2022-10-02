using Microsoft.Azure.ServiceBus;
using Newtonsoft.Json;
using SS.Alteration.Application.Events;
using System.Text;

namespace SS.Alteration.API.Consumers
{
    public class OrderConsumer : BackgroundService
    {
        private readonly ISubscriptionClient _subscriptionClient;

        public OrderConsumer(ISubscriptionClient subscriptionClient)
        {
            _subscriptionClient = subscriptionClient;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _subscriptionClient.RegisterMessageHandler((message, token) =>
            {
                var orderPaid = JsonConvert.DeserializeObject<OrderFinished>(Encoding.UTF8.GetString(message.Body));

                // Notify Customer
                // CustomerCommunication service will be called via mediatr below


                return _subscriptionClient.CompleteAsync(message.SystemProperties.LockToken);
            }, new MessageHandlerOptions(args => Task.CompletedTask)
            {
                AutoComplete = false,
                MaxConcurrentCalls = 1
            });

            return Task.CompletedTask;
        }
    }
}
