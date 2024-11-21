using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2257._Count_Unguarded_Cells_in_the_Grid;

[TestFixture(TestName = "2257. Count Unguarded Cells in the Grid")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(4, 6, "[[0,0],[1,1],[2,3]]", "[[0,1],[2,2],[1,4]]", 7)]
    [TestCase(3, 3, "[[1,1]]", "[[0,1],[1,0],[2,1],[1,2]]", 4)]
    public void Test(int input1, int input2, string input3, string input4, int output)
    {
        var solution = new Solution();
        var actual = solution.CountUnguarded(input1, input2, input3.ParseIntArray2d(), input4.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
