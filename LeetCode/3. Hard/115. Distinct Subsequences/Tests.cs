using NUnit.Framework;

namespace LeetCode._3._Hard._115._Distinct_Subsequences;

[TestFixture(TestName = "115. Distinct Subsequences")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("rabbbit", "rabbit", 3)]
    [TestCase("babgbag", "bag", 5)]
    [TestCase("aaa", "aa", 3)]
    [TestCase("aaaa", "aa", 6)]
    [TestCase("aaaaa", "aa", 10)]
    [TestCase("b", "a", 0)]
    [TestCase("CBAZTAAABBCTA", "CAT", 5)]
    public void Test(string input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.NumDistinct(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
