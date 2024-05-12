using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._11._Container_With_Most_Water;

[TestFixture(TestName = "11. Container With Most Water")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,8,6,2,5,4,8,3,7]", 49)]
    [TestCase("[1,1]", 1)]
    [TestCase("[1,3,2,5,25,24,5]", 24)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxArea(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}