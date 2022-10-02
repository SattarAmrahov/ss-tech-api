using SS.Alteration.Domain.Entities.Common;

namespace SS.Alteration.Domain.Entities
{
    public class AlterationForm : BaseEntity
    {
        public Guid SuitId { get; set; }
        public Suit Suit { get; set; }
        public List<Instruction> Instructions { get; set; }

    }
}
