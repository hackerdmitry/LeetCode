using NUnit.Framework;

namespace LeetCode._2._Middle._2981._Find_Longest_Special_Substring_That_Occurs_Thrice_I;

[TestFixture(TestName = "2981. Find Longest Special Substring That Occurs Thrice I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("eccdnmcnkl", 1)]
    [TestCase("aaaa", 2)]
    [TestCase("acc", -1)]
    [TestCase("abcdef", -1)]
    [TestCase("abcaba", 1)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaximumLength(input);
        Assert.AreEqual(output, actual);
    }
}
