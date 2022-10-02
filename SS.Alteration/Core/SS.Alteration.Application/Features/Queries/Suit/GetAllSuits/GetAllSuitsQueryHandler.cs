using MediatR;
using SS.Alteration.Application.Repositories;

namespace SS.Alteration.Application.Features.Queries.Suit.GetAllSuits
{
    public class GetAllSuitsQueryHandler : IRequestHandler<GetAllSuitsQueryRequest, GetAllSuitsQueryResponse>
    {
        readonly ISuitReadRepository _suitReadRepository;

        public GetAllSuitsQueryHandler(ISuitReadRepository suitReadRepository)
        {
            _suitReadRepository = suitReadRepository;
        }

        public async Task<GetAllSuitsQueryResponse> Handle(GetAllSuitsQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _suitReadRepository.GetAll(false).Count();

            var suits = _suitReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size)
                .Select(p => new
                {
                    p.Id,
                    p.Code,
                    p.CreatedAt,
                    p.UpdatedAt
                }).ToList();

            return new()
            {
                Suits = suits,
                TotalSuitsCount = totalCount
            };


        }
    }
}
