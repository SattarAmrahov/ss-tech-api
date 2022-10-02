namespace SS.Alteration.Application.Features.Commands.Order.CreateOrder
{
    public class CreateOrderCommandResponse
    {
        public string Id { get; set; }
        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }
        public string OrderStatus { get; set; }
        public string SuitCode { get; set; }
        public List<string> Instructions { get; set; }
    }
}
