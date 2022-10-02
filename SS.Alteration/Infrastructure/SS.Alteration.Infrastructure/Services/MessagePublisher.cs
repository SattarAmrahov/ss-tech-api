using Microsoft.Azure.ServiceBus;
using Newtonsoft.Json;
using SS.Alteration.Application.Services;
using System.Text;

namespace SS.Alteration.Infrastructure.Services
{
    public class MessagePublisher : IMessagePublisher
    {
        private readonly ITopicClient _topicClient;

        public MessagePublisher(ITopicClient topicClient)
        {
            _topicClient = topicClient;
        }

        public Task Publish<T>(T message)
        {
            var messageToSend = new Message(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message)));
            messageToSend.UserProperties["MessageType"] = typeof(T).Name;
            return _topicClient.SendAsync(messageToSend);
        }

    }
}
