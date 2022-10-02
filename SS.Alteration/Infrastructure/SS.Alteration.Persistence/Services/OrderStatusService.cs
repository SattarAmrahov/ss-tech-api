using SS.Alteration.Application.Repositories;
using SS.Alteration.Application.Services;
using SS.Alteration.Domain.Entities;

namespace SS.Alteration.Persistence.Services
{
    public class OrderStatusService : IOrderStatusService
    {
        readonly IOrderStatusReadRepository _orderStatusReadRepository;

        public OrderStatusService(IOrderStatusReadRepository orderStatusReadRepository)
        {
            _orderStatusReadRepository = orderStatusReadRepository;
        }

        public async Task<OrderStatus> GetOrderStatusByNameAsync(string orderStatusName)
        {
            return await _orderStatusReadRepository.GetSingleAsync(s => s.Name == orderStatusName);
        }
    }
}
