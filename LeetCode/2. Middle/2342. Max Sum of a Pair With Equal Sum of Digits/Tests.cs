using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2342._Max_Sum_of_a_Pair_With_Equal_Sum_of_Digits;

[TestFixture(TestName = "2342. Max Sum of a Pair With Equal Sum of Digits")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[10,12,19,14]", -1)]
    [TestCase("[18,43,36,13,7]", 54)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaximumSum(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
