using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._2210._Count_Hills_and_Valleys_in_an_Array;

[TestFixture(TestName = "2210. Count Hills and Valleys in an Array")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,4,1,1,6,5]", 3)]
    [TestCase("[6,6,5,5,4,1]", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.CountHillValley(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}