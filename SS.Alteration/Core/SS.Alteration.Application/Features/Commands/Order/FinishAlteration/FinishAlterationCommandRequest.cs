using MediatR;

namespace SS.Alteration.Application.Features.Commands.Order.FinishAlteration
{
    public class FinishAlterationCommandRequest : IRequest<FinishAlterationCommandResponse>
    {
        public string OrderId { get; set; }
    }
}
