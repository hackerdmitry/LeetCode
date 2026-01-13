using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._547._Number_of_Provinces;

[TestFixture(TestName = "547. Number of Provinces")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[1,1,0],[1,1,0],[0,0,1]]", 2)]
    [TestCase("[[1,0,0],[0,1,0],[0,0,1]]", 3)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.FindCircleNum(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
