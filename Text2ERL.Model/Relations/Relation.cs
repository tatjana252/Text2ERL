using static Text2ERL.Model.Relation;

namespace Text2ERL.Model
{

    public partial class Relation
    {
        public string Name { get; set; } // should be unique
        public virtual Mapping Mapping1 { get; set; }
        public virtual Mapping Mapping2 { get; set; }

    }
}
