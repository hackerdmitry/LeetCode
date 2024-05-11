using NUnit.Framework;

namespace LeetCode._1._Easy._13._Roman_to_Integer;

[TestFixture(TestName = "13. Roman to Integer")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("III", 3)]
    [TestCase("LVIII", 58)]
    [TestCase("MCMXCIV", 1994)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.RomanToInt(input);
        Assert.AreEqual(output, actual);
    }
}