using SS.Alteration.Application.DTOs.Order;

namespace SS.Alteration.Application.Services
{
    public interface IOrderService
    {
        Task<SingleOrder> CreateOrderAsync(CreateOrder createOrder);
        Task<OrderList> GetAllOrdersAsync(int page, int size);
        Task<SingleOrder> GetOrderByIdAsync(string id);
        Task PayOrderAsync(string id, decimal amount);
        Task ChangeAlterationStatusAsync(string orderId, Guid statusId);
    }
}
