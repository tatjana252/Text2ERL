using Text2ERL.Model.Entities;

namespace Text2ERL.Model
{

    public partial class Relation
    {
        public class Mapping
        {
            public Entity DomainEntity { get; set; }
            public Entity CoDomainEntity { get; set; }
            public CardinalityBound UpperBound { get; set; }
            public CardinalityBound LowerBound { get; set; }
            public string? Description { get; set; }
        }

    }
}
