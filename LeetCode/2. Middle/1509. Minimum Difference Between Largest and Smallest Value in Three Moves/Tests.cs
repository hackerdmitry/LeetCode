using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1509._Minimum_Difference_Between_Largest_and_Smallest_Value_in_Three_Moves;

[TestFixture(TestName = "1509. Minimum Difference Between Largest and Smallest Value in Three Moves")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[5,3,2,4]", 0)]
    [TestCase("[1,5,0,10,14]", 1)]
    [TestCase("[3,100,20]", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinDifference(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
