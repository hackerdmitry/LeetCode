using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2924._Find_Champion_II;

[TestFixture(TestName = "2924. Find Champion II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(2, "[[1,0]]", 1)]
    [TestCase(3, "[[0,1],[1,2]]", 0)]
    [TestCase(4, "[[0,2],[1,3],[1,2]]", -1)]
    [TestCase(1, "[]", 0)]
    public void Test(int input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.FindChampion(input1, input2.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
