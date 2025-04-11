using Text2ERL.Model.Entities;

namespace Text2ERL.Model
{
    public class WeakRelation : Relation
    {
        public WeakRelation(Entity weakEntity, Entity strongEntity, CardinalityBound upperBound, CardinalityBound lowerBound, string description = "")
        {
            Name = weakEntity.Name + "is_weak_of" +strongEntity.Name;
            Mapping1 = new Mapping { 
             DomainEntity = strongEntity,
             CoDomainEntity = weakEntity,
             LowerBound = lowerBound,
             UpperBound = upperBound,
             Description = description
            };
            Mapping2 = new Mapping
            {
                DomainEntity = weakEntity,
                CoDomainEntity = strongEntity,
                LowerBound = new CardinalityBound("1"),
                UpperBound = new CardinalityBound("1"),
                Description = "is identified by"
            };
        }
    }
}
