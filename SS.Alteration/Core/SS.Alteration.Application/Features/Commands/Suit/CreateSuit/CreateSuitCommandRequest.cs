using MediatR;

namespace SS.Alteration.Application.Features.Commands.Suit.CreateSuit
{
    public class CreateSuitCommandRequest : IRequest<CreateSuitCommandResponse>
    {
        public string Code { get; set; }
    }
}
