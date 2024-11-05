namespace RomanNumeralConverter;

public class RomanNumeral
{
    private Dictionary<string, long> Mappings = new ()
    {
        { "I", 1 },
        { "II", 2 },
        { "III", 3 },
        { "IV", 4 },
        { "V", 5 },
        { "IX", 9 },
        { "X", 10 },
        { "XL", 40 },
        { "L", 50 },
        { "XC", 90 },
        { "C", 100 },
        { "CC", 200 },
        { "CCC", 300 },
        { "CD", 400 },
        { "D", 500 },
        { "CM", 900 },
        { "M", 1000 },
        { "MM", 2000 },
        { "MMM", 3000 }
    };
    public string RomanValue { get; private set; }
    public long Value { get; private set; }

    public RomanNumeral(string value)
    {
        RomanValue = value;
        Value = Convert();
    }

    long Convert()
    {
        var romanValue = RomanValue;
        long totalValue = 0;
        while (romanValue.Length>0)
        {
            for (int i = Math.Min(3, romanValue.Length); i > 0; i--)
            {
                var part = romanValue[0..i];
                if (Mappings.ContainsKey(part))
                {
                    var partValue = Mappings[part];
                    romanValue = romanValue[i..];
                    totalValue += partValue;
                    break;
                }
            }
        }
        return totalValue;
    }
}