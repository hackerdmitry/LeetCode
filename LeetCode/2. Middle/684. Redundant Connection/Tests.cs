using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._684._Redundant_Connection;

[TestFixture(TestName = "684. Redundant Connection")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[15,24],[17,19],[5,26],[28,35],[7,41],[16,48],[13,18],[24,38],[19,47],[3,42],[19,32],[27,28],[18,34],[42,46],[28,45],[9,29],[26,43],[18,24],[26,49],[6,47],[8,33],[32,48],[1,32],[12,30],[9,22],[10,15],[6,50],[22,25],[11,40],[1,41],[4,17],[26,34],[39,47],[20,26],[33,44],[3,40],[5,37],[11,17],[14,24],[3,31],[21,23],[8,40],[21,27],[23,36],[2,42],[15,33],[12,27],[12,42],[1,6],[23,29]]", "[1,6]")]
    [TestCase("[[1,3],[3,4],[1,5],[3,5],[2,3]]", "[3,5]")]
    [TestCase("[[1,2],[2,3],[3,4],[4,5],[5,6],[2,4]]", "[2,4]")]
    [TestCase("[[1,2],[1,3],[2,3]]", "[2,3]")]
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
