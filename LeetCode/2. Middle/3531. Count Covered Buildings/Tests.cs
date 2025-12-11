using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3531._Count_Covered_Buildings;

[TestFixture(TestName = "3531. Count Covered Buildings")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(3, "[[1,2],[2,2],[3,2],[2,1],[2,3]]", 1)]
    [TestCase(3, "[[1,1],[1,2],[2,1],[2,2]]", 0)]
    [TestCase(5, "[[1,3],[3,2],[3,3],[3,5],[5,3]]", 1)]
    public void Test(int input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.CountCoveredBuildings(input1, input2.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
