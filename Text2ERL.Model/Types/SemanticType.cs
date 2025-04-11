using Text2ERL.Model.Constraints;

namespace Text2ERL.Model.Types
{
    public class SemanticType : IType
    {
        public string Name { get; set; }
        public PredefinedType PredefinedType { get; set; }
        public Constraint Constraint { get; set; }
    }
}
