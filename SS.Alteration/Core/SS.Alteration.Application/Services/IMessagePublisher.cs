namespace SS.Alteration.Application.Services
{
    public interface IMessagePublisher
    {
        Task Publish<T>(T message);
    }
}
