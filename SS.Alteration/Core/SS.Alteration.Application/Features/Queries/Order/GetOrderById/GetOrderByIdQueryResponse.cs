namespace SS.Alteration.Application.Features.Queries.Order.GetOrderById
{
    public class GetOrderByIdQueryResponse
    {
        public string Id { get; set; }
        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }
        public string OrderStatus { get; set; }
        public string SuitCode { get; set; }
        public List<string> Instructions { get; set; }
    }
}
