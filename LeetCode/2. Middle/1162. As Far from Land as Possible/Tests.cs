using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1162._As_Far_from_Land_as_Possible;

[TestFixture(TestName = "1162. As Far from Land as Possible")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[1,0,1],[0,0,0],[1,0,1]]", 2)]
    [TestCase("[[1,0,0],[0,0,0],[0,0,0]]", 4)]
    [TestCase("[[0,0,0,0],[0,0,0,0],[0,0,0,0],[0,0,0,0]]", -1)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxDistance(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}