using SS.Alteration.Domain.Entities;

namespace SS.Alteration.Application.Services
{
    public interface IOrderStatusService
    {
        Task<OrderStatus> GetOrderStatusByNameAsync(string orderStatusName);
    }
}
