using MediatR;
using SS.Alteration.Application.Services;
using SS.Alteration.Domain.Enums;

namespace SS.Alteration.Application.Features.Commands.Order.ChangeOrderStatus
{
    public class StartAlterationCommandHandler : IRequestHandler<StartAlterationCommandRequest, StartAlterationCommandResponse>
    {
        private readonly IOrderService _orderService;
        private readonly IOrderStatusService _orderStatusService;

        public StartAlterationCommandHandler(IOrderService orderService, IOrderStatusService orderStatusService)
        {
            _orderService = orderService;
            _orderStatusService = orderStatusService;
        }

        public async Task<StartAlterationCommandResponse> Handle(StartAlterationCommandRequest request, CancellationToken cancellationToken)
        {
            var orderStatus = await _orderStatusService.GetOrderStatusByNameAsync(EAlterationStatus.InProgress.ToString());

            await _orderService.ChangeAlterationStatusAsync(request.OrderId, orderStatus.Id);

            return new();

        }
    }
}
