using MediatR;
using Microsoft.AspNetCore.Mvc;
using SS.Alteration.Application.Events;
using SS.Alteration.Application.Features.Commands.Order.ChangeOrderStatus;
using SS.Alteration.Application.Features.Commands.Order.CreateOrder;
using SS.Alteration.Application.Features.Commands.Order.FinishAlteration;
using SS.Alteration.Application.Features.Commands.Order.PayOrder;
using SS.Alteration.Application.Features.Queries.Order.GetAllOrders;
using SS.Alteration.Application.Features.Queries.Order.GetOrderById;
using SS.Alteration.Application.Services;

namespace SS.Alteration.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMessagePublisher _messagePublisher;

        public OrdersController(IMediator mediator, IMessagePublisher messagePublisher)
        {
            _mediator = mediator;
            _messagePublisher = messagePublisher;
        }



        [HttpGet]
        public async Task<ActionResult> Get([FromQuery] GetAllOrdersQueryRequest getAllOrdersQueryRequest)
        {
            GetAllOrdersQueryResponse response = await _mediator.Send(getAllOrdersQueryRequest);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult> GetById([FromRoute] GetOrderByIdQueryRequest getOrderByIdQueryRequest)
        {
            GetOrderByIdQueryResponse response = await _mediator.Send(getOrderByIdQueryRequest);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreateOrderCommandRequest createOrderCommandRequest)
        {
            var response = await _mediator.Send(createOrderCommandRequest);
            return Ok(response);
        }

        [HttpPost("payment")]
        public async Task<ActionResult> Payment(PayOrderCommandRequest payOrderCommandRequest)
        {
            var response = await _mediator.Send(payOrderCommandRequest);

            return Ok(response);
        }

        [HttpPost("startAlteration")]
        public async Task<ActionResult> StartAlteration(StartAlterationCommandRequest startAlterationCommandRequest)
        {
            var response = await _mediator.Send(startAlterationCommandRequest);
            return Ok(response);
        }

        [HttpPost("finishAlteration")]
        public async Task<ActionResult> FinishAlteration(FinishAlterationCommandRequest finishAlterationCommandRequest)
        {
            var response = await _mediator.Send(finishAlterationCommandRequest);

            // Publish OrderPaid event
            var orderFinished = new OrderFinished
            {
                Id = response.Id,
                SuitCode = response.SuitCode,
                OrderStatus = response.OrderStatus,
                IsPaid = response.IsPaid,
                Amount = response.Amount
            };
            await _messagePublisher.Publish(orderFinished);

            return Ok(response);
        }

    }
}
