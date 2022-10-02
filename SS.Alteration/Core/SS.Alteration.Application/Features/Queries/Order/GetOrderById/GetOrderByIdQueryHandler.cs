using MediatR;
using SS.Alteration.Application.Services;

namespace SS.Alteration.Application.Features.Queries.Order.GetOrderById
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQueryRequest, GetOrderByIdQueryResponse>
    {
        readonly IOrderService _orderService;

        public GetOrderByIdQueryHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<GetOrderByIdQueryResponse> Handle(GetOrderByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _orderService.GetOrderByIdAsync(request.Id);
            return new()
            {
                Id = data.Id,
                Amount = data.Amount,
                IsPaid = data.IsPaid,
                SuitCode = data.SuitCode,
                OrderStatus = data.OrderStatus,
                Instructions = data.Instructions
            };
        }
    }
}
