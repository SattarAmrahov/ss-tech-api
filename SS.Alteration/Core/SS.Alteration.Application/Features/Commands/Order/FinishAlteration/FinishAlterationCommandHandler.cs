using MediatR;
using SS.Alteration.Application.Services;
using SS.Alteration.Domain.Enums;

namespace SS.Alteration.Application.Features.Commands.Order.FinishAlteration
{
    public class FinishAlterationCommandHandler : IRequestHandler<FinishAlterationCommandRequest, FinishAlterationCommandResponse>
    {
        private readonly IOrderService _orderService;
        private readonly IOrderStatusService _orderStatusService;

        public FinishAlterationCommandHandler(IOrderService orderService, IOrderStatusService orderStatusService)
        {
            _orderService = orderService;
            _orderStatusService = orderStatusService;
        }

        public async Task<FinishAlterationCommandResponse> Handle(FinishAlterationCommandRequest request, CancellationToken cancellationToken)
        {
            var orderStatus = await _orderStatusService.GetOrderStatusByNameAsync(EAlterationStatus.Ready.ToString());

            await _orderService.ChangeAlterationStatusAsync(request.OrderId, orderStatus.Id);
            var order = await _orderService.GetOrderByIdAsync(request.OrderId);
            
            return new() { 
                Amount = order.Amount,
                Id = order.Id,
                IsPaid = order.IsPaid,
                OrderStatus = order.OrderStatus,
                SuitCode = order.SuitCode
            };
        }
    }
}
