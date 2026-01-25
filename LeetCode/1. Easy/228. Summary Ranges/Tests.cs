using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._228._Summary_Ranges;

[TestFixture(TestName = "228. Summary Ranges")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[0,1,2,4,5,7]", "[\"0->2\",\"4->5\",\"7\"]")]
    [TestCase("[0,2,3,4,6,8,9]", "[\"0\",\"2->4\",\"6\",\"8->9\"]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.SummaryRanges(input.ParseIntArray());
        Assert.AreEqual(output.ParseStringArray(), actual);
    }
}
