using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._846._Hand_of_Straights;

[TestFixture(TestName = "846. Hand of Straights")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,6,2,3,4,7,8]", 3, true)]
    [TestCase("[1,2,3,4,5]", 4, false)]
    public void Test(string input1, int input2, bool output)
    {
        var solution = new Solution();
        var actual = solution.IsNStraightHand(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}