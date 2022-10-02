namespace SS.Alteration.Application.Services
{
    public interface INotificationService
    {
        Task SendAsync(object message);
    }
}
