using MediatR;

namespace SS.Alteration.Application.Features.Commands.Order.CreateOrder
{
    public class CreateOrderCommandRequest : IRequest<CreateOrderCommandResponse>
    {
        public decimal Amount { get; set; }
        public Guid SuitId { get; set; }
        public List<string> Instructions { get; set; }

    }
}
