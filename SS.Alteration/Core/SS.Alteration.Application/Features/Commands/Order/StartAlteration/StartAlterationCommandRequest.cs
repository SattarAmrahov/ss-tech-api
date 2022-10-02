using MediatR;

namespace SS.Alteration.Application.Features.Commands.Order.ChangeOrderStatus
{
    public class StartAlterationCommandRequest : IRequest<StartAlterationCommandResponse>
    {
        public string OrderId { get; set; }
    }
}
