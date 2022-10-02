using MediatR;

namespace SS.Alteration.Application.Features.Queries.Suit.GetAllSuits
{
    public class GetAllSuitsQueryRequest : IRequest<GetAllSuitsQueryResponse>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
    }
}
