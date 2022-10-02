namespace SS.Alteration.Application.Exceptions
{
    public class OrderNotPaidException : Exception
    {
        public OrderNotPaidException() : base("Order not paid.")
        {
        }
        public OrderNotPaidException(string? message) : base(message)
        {
        }
    }
}
