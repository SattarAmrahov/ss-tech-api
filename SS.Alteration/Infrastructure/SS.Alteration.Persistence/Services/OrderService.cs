using Microsoft.EntityFrameworkCore;
using SS.Alteration.Application.DTOs.Order;
using SS.Alteration.Application.Exceptions;
using SS.Alteration.Application.Repositories;
using SS.Alteration.Application.Services;

namespace SS.Alteration.Persistence.Services
{
    public class OrderService : IOrderService
    {

        readonly IOrderWriteRepository _orderWriteRepository;
        readonly IOrderReadRepository _orderReadRepository;

        public OrderService(IOrderWriteRepository orderWriteRepository, IOrderReadRepository orderReadRepository)
        {
            _orderWriteRepository = orderWriteRepository;
            _orderReadRepository = orderReadRepository;
        }

        public async Task<SingleOrder> CreateOrderAsync(CreateOrder createOrder)
        {
            if (createOrder.AlterationForm.Instructions.Count > 2)
            {
                throw new InstructionCountExceedException(); 
            }

            var order = await _orderWriteRepository.InsertAsync(new()
            {
                OrderStatusId = createOrder.OrderStatusId,
                Amount = createOrder.Amount,
                IsPaid = false,
                AlterationForm = new()
                {
                    SuitId = createOrder.AlterationForm.SuitId,
                    Instructions = createOrder.AlterationForm.Instructions.Select(i => new Domain.Entities.Instruction { Text = i }).ToList()
                }
            });
            await _orderWriteRepository.SaveAsync();

            return await GetOrderByIdAsync(order.Id.ToString());
        }

        public async Task<OrderList> GetAllOrdersAsync(int page, int size)
        {
            var query = _orderReadRepository.Table.Include(o => o.OrderStatus);

            var data = query.Skip(page * size).Take(size);

            return new()
            {
                TotalOrderCount = await query.CountAsync(),
                Orders = await data.Select(o => new
                {
                    Id = o.Id,
                    CreatedAt = o.CreatedAt,
                    Amount = o.Amount,
                    IsPaid = o.IsPaid,
                    Status = o.OrderStatus.Name
                }).ToListAsync()
            };
        }

        public async Task<SingleOrder> GetOrderByIdAsync(string id)
        {
            var data = await _orderReadRepository.Table
                                   .Include(o => o.OrderStatus)
                                   .Include(o => o.AlterationForm)
                                        .ThenInclude(a => a.Instructions)
                                   .Include(o => o.AlterationForm)
                                        .ThenInclude(a => a.Suit)
                                   .FirstOrDefaultAsync(o => o.Id == Guid.Parse(id));

            return new()
            {
                Id = data.Id.ToString(),
                Instructions = data.AlterationForm.Instructions.Select(i => i.Text).ToList(),
                Amount = data.Amount,
                IsPaid = data.IsPaid,
                OrderStatus = data.OrderStatus.Name,
                SuitCode = data.AlterationForm.Suit.Code
            };
        }

        public async Task PayOrderAsync(string id, decimal amount)
        {
            var order = await _orderReadRepository.GetByIdAsync(id);
            if (order == null)
            {
                throw new OrderNotFoundException();
            }

            if (order.Amount != amount)
            {
                throw new OrderPaymentException("Paid amount is not equal to the order amount.");
            }

            order.IsPaid = true;
            await _orderWriteRepository.SaveAsync();
        }

        public async Task ChangeAlterationStatusAsync(string orderId, Guid statusId)
        {
            var order = await _orderReadRepository.GetByIdAsync(orderId);
            if (!order.IsPaid)
            {
                throw new OrderNotPaidException();
            }
            if (order.OrderStatusId == statusId)
            {
                throw new OrderStatusException($"Order status is already {order.OrderStatus.Name}");
            }


            order.OrderStatusId = statusId;
            _orderWriteRepository.Update(order);
            await _orderWriteRepository.SaveAsync();
        }
    }
}
