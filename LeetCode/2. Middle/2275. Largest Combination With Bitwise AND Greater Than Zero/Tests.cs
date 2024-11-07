using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2275._Largest_Combination_With_Bitwise_AND_Greater_Than_Zero;

[TestFixture(TestName = "2275. Largest Combination With Bitwise AND Greater Than Zero")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[16,17,71,62,12,24,14]", 4)]
    [TestCase("[8,8]", 2)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.LargestCombination(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
