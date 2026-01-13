using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1466._Reorder_Routes_to_Make_All_Paths_Lead_to_the_City_Zero;

[TestFixture(TestName = "1466. Reorder Routes to Make All Paths Lead to the City Zero")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(5, "[[1,0],[1,2],[3,2],[3,4]]", 2)]
    [TestCase(6, "[[0,1],[1,3],[2,3],[4,0],[4,5]]", 3)]
    [TestCase(3, "[[1,0],[2,0]]", 0)]
    [TestCase(3, "[[0,1],[1,2],[2,0]", 0)]
    public void Test(int input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MinReorder(input1, input2.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
