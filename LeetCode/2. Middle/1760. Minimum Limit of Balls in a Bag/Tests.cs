using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1760._Minimum_Limit_of_Balls_in_a_Bag;

[TestFixture(TestName = "1760. Minimum Limit of Balls in a Bag")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[9]", 2, 3)]
    [TestCase("[2,4,8,2]", 4, 2)]
    [TestCase("[1,2,3]", 3, 1)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MinimumSize(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
