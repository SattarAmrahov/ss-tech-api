using MediatR;

namespace SS.Alteration.Application.Features.Commands.Order.PayOrder
{
    public class PayOrderCommandRequest : IRequest<PayOrderCommandResponse>
    {
        public string OrderId { get; set; }
        public decimal Amount { get; set; }
    }
}
