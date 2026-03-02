using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1536._Minimum_Swaps_to_Arrange_a_Binary_Grid;

[TestFixture(TestName = "1536. Minimum Swaps to Arrange a Binary Grid")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[0,0,1],[1,1,0],[1,0,0]]", 3)]
    [TestCase("[[0,1,1,0],[0,1,1,0],[0,1,1,0],[0,1,1,0]]", -1)]
    [TestCase("[[1,0,0],[1,1,0],[1,1,1]]", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinSwaps(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
