using Text2ERL.Model.Entities;
using static Text2ERL.Model.Relation;

namespace Text2ERL.Model.Relations
{
    public class GeneralizationSpecialization
    {
        public Entity SuperEntity { get; set; }
        public Entity[] SubEntities { get; set; }
        public CardinalityBound LowerBound { get; set; }
        public CardinalityBound UpperBound { get; set; }
    }
}
