using SS.Alteration.Domain.Entities.Common;

namespace SS.Alteration.Domain.Entities
{
    public class AlterationForm : BaseEntity
    {
        public Guid SuitId { get; set; }
        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }
        public Guid AlterationStatusId { get; set; }
        public AlterationStatus AlterationStatus { get; set; }
        public ICollection<Instruction> Instructions { get; set; }

    }
}
