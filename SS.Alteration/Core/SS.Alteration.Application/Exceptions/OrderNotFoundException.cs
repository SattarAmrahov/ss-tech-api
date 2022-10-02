namespace SS.Alteration.Application.Exceptions
{
    public class OrderNotFoundException : Exception
    {
        public OrderNotFoundException() : base("Order not found.")
        {
        }

        public OrderNotFoundException(string? message) : base(message)
        {
        }
    }
}
