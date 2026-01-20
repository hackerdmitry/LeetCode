using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._274._H_Index;

[TestFixture(TestName = "274. H-Index")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[3,0,6,1,5]", 3)]
    [TestCase("[1,3,1]", 1)]
    [TestCase("[100]", 1)]
    [TestCase("[0,0,2]", 1)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.HIndex(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
