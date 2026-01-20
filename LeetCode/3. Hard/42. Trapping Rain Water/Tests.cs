using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._42._Trapping_Rain_Water;

[TestFixture(TestName = "42. Trapping Rain Water")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,0,2]", 2)]
    [TestCase("[0,1,0,2,1,0,1,3,2,1,2,1]", 6)]
    [TestCase("[4,2,0,3,2,5]", 9)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.Trap(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
