namespace Text2ERL.Model.Entities
{
    public class WeakEntity : Entity
    {
        public Entity StrongEntity { get; set; }
        public WeakRelation StrongEntityRelation { get; set; }
    }
}
