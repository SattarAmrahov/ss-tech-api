using MediatR;
using Microsoft.AspNetCore.Mvc;
using SS.Alteration.Application.Features.Commands.Suit.CreateSuit;
using SS.Alteration.Application.Features.Queries.Suit.GetAllSuits;

namespace SS.Alteration.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuitsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SuitsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllSuitsQueryRequest getAllSuitsQueryRequest)
        {
            GetAllSuitsQueryResponse response = await _mediator.Send(getAllSuitsQueryRequest);
            return Ok(response);
        }

     
        [HttpPost]
        public async Task<IActionResult> Post(CreateSuitCommandRequest createSuitCommandRequest)
        {
            var response = await _mediator.Send(createSuitCommandRequest);
            return Ok(response);
        }


    }
}
