using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._120._Triangle;

[TestFixture(TestName = "120. Triangle")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[2],[3,4],[6,5,7],[4,1,8,3]]", 11)]
    [TestCase("[[-10]]", -10)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinimumTotal(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
