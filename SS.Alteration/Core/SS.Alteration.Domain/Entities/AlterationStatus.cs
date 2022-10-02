using SS.Alteration.Domain.Entities.Common;

namespace SS.Alteration.Domain.Entities
{
    public class AlterationStatus : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<AlterationForm> AlterationForms { get; set; }
    }
}
