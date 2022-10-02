namespace SS.Alteration.Infrastructure
{
    public class ServiceBusConfig
    {
        public string ConnectionString { get; set; }
        public string TopicName { get; set; }
        public string SubscriptionName { get; set; }
    }
}
