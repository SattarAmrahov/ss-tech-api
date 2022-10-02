using MediatR;
using SS.Alteration.Application.Services;
using SS.Alteration.Domain.Enums;

namespace SS.Alteration.Application.Features.Commands.Order.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommandRequest, CreateOrderCommandResponse>
    {
        private readonly IOrderService _orderService;
        private readonly IOrderStatusService _orderStatusService;

        public CreateOrderCommandHandler(IOrderService orderService, IOrderStatusService orderStatusService)
        {
            _orderService = orderService;
            _orderStatusService = orderStatusService;
        }

        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var orderStatus = await _orderStatusService.GetOrderStatusByNameAsync(EAlterationStatus.Received.ToString());

            var order = await _orderService.CreateOrderAsync(new()
            {
                AlterationForm = new() { SuitId = request.SuitId, Instructions = request.Instructions },
                Amount = request.Amount,
                OrderStatusId = orderStatus.Id
            });

            return new()
            {
                Amount = order.Amount,
                IsPaid = order.IsPaid,
                Id = order.Id,
                Instructions = order.Instructions,
                OrderStatus = order.OrderStatus,
                SuitCode = order.SuitCode
            };

        }
    }
}
