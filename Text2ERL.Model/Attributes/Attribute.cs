using Text2ERL.Model.Constraints;
using Text2ERL.Model.Types;

namespace Text2ERL.Model.Attributes
{
    public class Attribute
    {
        public string Name { get; set; }
        public PredefinedType Type { get; set; }
        public Constraint Constraint { get; set; }
    }
}
