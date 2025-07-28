using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2044._Count_Number_of_Maximum_Bitwise_OR_Subsets;

[TestFixture(TestName = "2044. Count Number of Maximum Bitwise-OR Subsets")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[3,1]", 2)]
    [TestCase("[2,2,2]", 7)]
    [TestCase("[3,2,1,5]", 6)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.CountMaxOrSubsets(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
