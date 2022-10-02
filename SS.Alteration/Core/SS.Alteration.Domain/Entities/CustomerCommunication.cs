using SS.Alteration.Domain.Entities.Common;

namespace SS.Alteration.Domain.Entities
{
    public class CustomerCommunication : BaseEntity
    {
        public Guid AlterationFormId { get; set; }
        public AlterationForm AlterationForm { get; set; }
        public bool IsNotificationSent { get; set; }
    }
}
