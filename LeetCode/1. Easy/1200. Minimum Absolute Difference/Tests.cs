using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1200._Minimum_Absolute_Difference;

[TestFixture(TestName = "1200. Minimum Absolute Difference")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[4,2,1,3]", "[[1,2],[2,3],[3,4]]")]
    [TestCase("[1,3,6,10,15]", "[[1,3]]")]
    [TestCase("[3,8,-10,23,19,-4,-14,27]", "[[-14,-10],[19,23],[23,27]]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.MinimumAbsDifference(input.ParseIntArray());
        Assert.AreEqual(output.ParseIntArray2d(), actual);
    }
}
