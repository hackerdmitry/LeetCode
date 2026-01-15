using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2943._Maximize_Area_of_Square_Hole_in_Grid;

[TestFixture(TestName = "2943. Maximize Area of Square Hole in Grid")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(2, 1, "[2,3]", "[2]", 4)]
    [TestCase(1, 1, "[2]", "[2]", 4)]
    [TestCase(2, 3, "[2,3]", "[2,4]", 4)]
    public void Test(int input1, int input2, string input3, string input4, int output)
    {
        var solution = new Solution();
        var actual = solution.MaximizeSquareHoleArea(input1, input2, input3.ParseIntArray(), input4.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
