using NUnit.Framework;

namespace LeetCode._1._Easy._3174._Clear_Digits;

[TestFixture(TestName = "3174. Clear Digits")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("abc", "abc")]
    [TestCase("ab1c", "ac")]
    [TestCase("abc1", "ab")]
    [TestCase("cb34", "")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.ClearDigits(input);
        Assert.AreEqual(output, actual);
    }
}
