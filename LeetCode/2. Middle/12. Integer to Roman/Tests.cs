using NUnit.Framework;

namespace LeetCode._2._Middle._12._Integer_to_Roman;

[TestFixture(TestName = "12. Integer to Roman")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(3749, "MMMDCCXLIX")]
    [TestCase(58, "LVIII")]
    [TestCase(1994, "MCMXCIV")]
    [TestCase(3999, "MMMCMXCIX")]
    public void Test(int input, string output)
    {
        var solution = new Solution();
        var actual = solution.IntToRoman(input);
        Assert.AreEqual(output, actual);
    }
}