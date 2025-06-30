using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._594._Longest_Harmonious_Subsequence;

[TestFixture(TestName = "594. Longest Harmonious Subsequence")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,4]", 2)]
    [TestCase("[1,3,2,2,5,2,3,7]", 5)]
    [TestCase("[1,1,1,1]", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.FindLHS(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
