namespace SS.Alteration.Application.DTOs.Order
{
    public class CreateOrder
    {
        public decimal Amount { get; set; }
        public Guid OrderStatusId { get; set; }
        public AlterationForm AlterationForm { get; set; }
    }
}
