using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._684._Redundant_Connection;

[TestFixture(TestName = "684. Redundant Connection")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[1,3],[3,4],[1,5],[3,5],[2,3]]", "[3,5]")]
    [TestCase("[[1,2],[1,3],[2,3]]", "[2,3]")]
    [TestCase("[[1,2],[2,3],[3,4],[4,5],[5,6],[2,4]]", "[2,4]")]
    [TestCase("[[1,2],[2,3],[1,3],[1,4]", "[1,3]")]
    [TestCase("[[1,2],[3,1],[2,3],[1,4]", "[2,3]")]
    [TestCase("[[3,1],[2,3],[1,2],[1,4]", "[1,2]")]
    [TestCase("[[1,2],[2,3],[3,4],[1,4],[1,5]]", "[1,4]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.FindRedundantConnection(input.ParseIntArray2d());
        var expected = output.ParseIntArray();
        actual.WriteLine("actual");
        expected.WriteLine("expected");
        Assert.AreEqual(expected, actual);
    }
}
