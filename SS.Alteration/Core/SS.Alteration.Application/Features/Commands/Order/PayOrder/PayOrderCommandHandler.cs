using MediatR;
using SS.Alteration.Application.Services;

namespace SS.Alteration.Application.Features.Commands.Order.PayOrder
{
    public class PayOrderCommandHandler : IRequestHandler<PayOrderCommandRequest, PayOrderCommandResponse>
    {
        private readonly IOrderService _orderService;
        private readonly IOrderStatusService _orderStatusService;

        public PayOrderCommandHandler(IOrderService orderService, IOrderStatusService orderStatusService)
        {
            _orderService = orderService;
            _orderStatusService = orderStatusService;
        }

        public async Task<PayOrderCommandResponse> Handle(PayOrderCommandRequest request, CancellationToken cancellationToken)
        {
            await _orderService.PayOrderAsync(request.OrderId, request.Amount);
            return new();
        }
    }
}
