namespace RomanNumeralConverter.Test;

[TestClass]
public class RomanNumeralTest
{
    [TestMethod]
    [DataRow("", 0)]
    [DataRow("MMMCMXCIX", 3999)]
    public void SpecialValues(string roman, long expectedValue)
    {
        var value = new RomanNumeral(roman).Value;
        Assert.AreEqual(expectedValue, value);
    }

    [TestMethod]
    [DataRow("I", 1)]
    [DataRow("V", 5)]
    [DataRow("X", 10)]
    [DataRow("L", 50)]
    [DataRow("C", 100)]
    [DataRow("D", 500)]
    [DataRow("M", 1000)]
    public void SingleDigitConversion(string roman, long expectedValue)
    {
        var value = new RomanNumeral(roman).Value;
        Assert.AreEqual(expectedValue, value);
    }

    [TestMethod]
    [DataRow("II", 2)]
    [DataRow("III", 3)]
    [DataRow("XX", 20)]
    [DataRow("XXX", 30)]
    [DataRow("CC", 200)]
    [DataRow("CCC", 300)]
    [DataRow("MM", 2000)]
    [DataRow("MMM", 3000)]
    public void Additive(string roman, long expectedValue)
    {
        var value = new RomanNumeral(roman).Value;
        Assert.AreEqual(expectedValue, value);
    }
    
    [TestMethod]
    [DataRow("IV", 4)]
    [DataRow("IX", 9)]
    [DataRow("XL", 40)]
    [DataRow("XC", 90)]
    [DataRow("CD", 400)]
    [DataRow("CM", 900)]
    public void Subtractive(string roman, long expectedValue)
    {
        var value = new RomanNumeral(roman).Value;
        Assert.AreEqual(expectedValue, value);
    }
}