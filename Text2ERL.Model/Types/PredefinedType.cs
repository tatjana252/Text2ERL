namespace Text2ERL.Model.Types
{
    public enum PredefinedTypes
    {
        String,
        Char,
        Int,
        Real,
        Bool,
        DateTime,
        Date,
        Time,
        Decimal,
        Text
    }
    public class PredefinedType : IType
    {
        public PredefinedTypes Type { get; set; }

        public PredefinedType(PredefinedTypes type)
        {
            Type = type;
        }

        public string GetDisplayName() => Type.ToString();
    }

}
