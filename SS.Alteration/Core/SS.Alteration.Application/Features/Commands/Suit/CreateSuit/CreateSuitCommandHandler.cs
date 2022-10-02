using MediatR;
using SS.Alteration.Application.Repositories;

namespace SS.Alteration.Application.Features.Commands.Suit.CreateSuit
{
    public class CreateSuitCommandHandler : IRequestHandler<CreateSuitCommandRequest, CreateSuitCommandResponse>
    {
        readonly ISuitWriteRepository _suitWriteRepository;

        public CreateSuitCommandHandler(ISuitWriteRepository suitWriteRepository)
        {
            _suitWriteRepository = suitWriteRepository;
        }

        public async Task<CreateSuitCommandResponse> Handle(CreateSuitCommandRequest request, CancellationToken cancellationToken)
        {
            await _suitWriteRepository.InsertAsync(new()
            {
                Id = Guid.NewGuid(),
                Code = request.Code
            });
            await _suitWriteRepository.SaveAsync();

            return new();

        }
    }
}
