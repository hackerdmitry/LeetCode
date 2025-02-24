using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2467._Most_Profitable_Path_in_a_Tree;

[TestFixture(TestName = "2467. Most Profitable Path in a Tree")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[0,1],[1,2],[2,3]]", 3, "[-5644,-6018,1188,-8502]", -11662)]
    [TestCase("[[0,1]]", 1, "[-7280,2350]", -7280)]
    [TestCase("[[0,1],[1,2],[1,3],[3,4]]", 3, "[-2,4,2,-4,6]", 6)]
    public void Test(string input1, int input2, string input3, int output)
    {
        var solution = new Solution();
        var actual = solution.MostProfitablePath(input1.ParseIntArray2d(), input2, input3.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
