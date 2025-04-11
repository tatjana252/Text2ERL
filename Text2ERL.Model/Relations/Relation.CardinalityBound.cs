namespace Text2ERL.Model
{

    public partial class Relation
    {

        public class CardinalityBound
        {
            private string? _value;
            public string? Value
            {
                get => _value;
                
                set
                {
                    if (!IsValid(value))
                        throw new ArgumentException("Invalid cardinality value.");

                    _value = value;
                }
            }

            public CardinalityBound(string value)
            {
                if (!IsValid(value))
                    throw new ArgumentException("Invalid cardinality value.");

                Value = value;
            }

            private bool IsValid(string? value)
            {
                if (value == "M") return true;
                if (int.TryParse(value, out int n) && n >= 0) return true;
                return false;
            }

            public override string? ToString() => Value;
        }

    }
}
