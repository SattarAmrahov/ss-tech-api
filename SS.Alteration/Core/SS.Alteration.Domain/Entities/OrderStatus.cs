using SS.Alteration.Domain.Entities.Common;

namespace SS.Alteration.Domain.Entities
{
    public class OrderStatus : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
