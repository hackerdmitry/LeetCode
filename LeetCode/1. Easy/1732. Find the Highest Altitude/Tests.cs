using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1732._Find_the_Highest_Altitude;

[TestFixture(TestName = "1732. Find the Highest Altitude")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[-5,1,5,0,-7]", 1)]
    [TestCase("[-4,-3,-2,-1,4,3,2]", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.LargestAltitude(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
