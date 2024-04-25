using NUnit.Framework;

namespace LeetCode._2._Middle._2370._Longest_Ideal_Subsequence;

[TestFixture(TestName = "2370. Longest Ideal Subsequence")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("acfgbd", 2, 4)]
    [TestCase("abcd", 3, 4)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.LongestIdealString(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
