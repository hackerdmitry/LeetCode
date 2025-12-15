using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2110._Number_of_Smooth_Descent_Periods_of_a_Stock;

[TestFixture(TestName = "2110. Number of Smooth Descent Periods of a Stock")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[3,2,1,4]", 7)]
    [TestCase("[8,6,7,7]", 4)]
    [TestCase("[1]", 1)]
    public void Test(string input, long output)
    {
        var solution = new Solution();
        var actual = solution.GetDescentPeriods(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
