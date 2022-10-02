using SS.Alteration.Domain.Entities.Common;

namespace SS.Alteration.Domain.Entities
{
    public class Instruction : BaseEntity
    {
        public string Text { get; set; }
        public Guid AlterationFormId { get; set; }
        public AlterationForm AlterationForm { get; set; }
    }
}
