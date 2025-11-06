using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3607._Power_Grid_Maintenance;

[TestFixture(TestName = "3607. Power Grid Maintenance")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(3, "[]", "[[1,1],[2,1],[1,1]]", "[1,-1]")]
    [TestCase(5, "[[1,2],[2,3],[3,4],[4,5]]", "[[1,3],[2,1],[1,1],[2,2],[1,2]]", "[3,2,3]")]
    public void Test(int input1, string input2, string input3, string output)
    {
        var solution = new Solution();
        var actual = solution.ProcessQueries(input1, input2.ParseIntArray2d(), input3.ParseIntArray2d());
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}