using NUnit.Framework;

namespace LeetCode._3._Hard._273._Integer_to_English_Words;

[TestFixture(TestName = "273. Integer to English Words")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(123, "One Hundred Twenty Three")]
    [TestCase(12345, "Twelve Thousand Three Hundred Forty Five")]
    [TestCase(1234567, "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven")]
    [TestCase(1_000_000_000, "One Billion")]
    public void Test(int input, string output)
    {
        var solution = new Solution();
        var actual = solution.NumberToWords(input);
        Assert.AreEqual(output, actual);
    }
}
