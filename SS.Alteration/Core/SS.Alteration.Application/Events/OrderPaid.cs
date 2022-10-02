namespace SS.Alteration.Application.Events
{
    public class OrderFinished
    {
        public string Id { get; set; }
        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }
        public string OrderStatus { get; set; }
        public string SuitCode { get; set; }
    }
}
