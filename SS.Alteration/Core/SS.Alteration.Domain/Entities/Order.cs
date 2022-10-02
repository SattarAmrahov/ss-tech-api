using SS.Alteration.Domain.Entities.Common;

namespace SS.Alteration.Domain.Entities
{
    public class Order : BaseEntity
    {
        public Guid AlterationFormId { get; set; }
        public Guid OrderStatusId { get; set; }
        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }

        public AlterationForm AlterationForm { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}
