using Text2ERL.Model.Constraints;
using Attribute = System.Attribute;

namespace Text2ERL.Model.Entities
{
    public class Entity 
    {
        public string Name { get; set; }
        public List<Attribute> Attributes { get; set; }
        public List<Constraint> Constraints { get; set; }
    }
}
