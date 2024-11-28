using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3243._Shortest_Distance_After_Road_Addition_Queries_I;

[TestFixture(TestName = "3243. Shortest Distance After Road Addition Queries I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(10, "[[4,9],[0,6],[1,5],[6,9]]", "[5,4,4,2]")]
    [TestCase(8, "[[0,4],[0,3],[3,6]]", "[4,4,3]")]
    [TestCase(8, "[[0,4],[3,6],[2,5],[0,3]]", "[4,4,4,3]")]
    [TestCase(7, "[[1,5],[3,6],[0,3]]", "[3,3,2]")]
    [TestCase(8, "[[5,7],[0,6]]", "[6,2]")]
    [TestCase(5, "[[2,4],[0,2],[0,4]]", "[3,2,1]")]
    [TestCase(4, "[[0,3],[0,2]]", "[1,1]")]
    [TestCase(9, "[[4,8],[0,4],[3,5],[1,7]]", "[5,2,2,2]")]
    [TestCase(9, "[[3,8],[0,4]]", "[4,4]")]
    public void Test(int input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.ShortestDistanceAfterQueries(input1, input2.ParseIntArray2d());
        var expected = output.ParseIntArray();
        actual.WriteLine("actual");
        expected.WriteLine("expected");
        Assert.AreEqual(expected, actual);
    }
}
