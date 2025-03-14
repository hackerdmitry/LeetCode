using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3356._Zero_Array_Transformation_II;

// ⭐
[TestFixture(TestName = "3356. Zero Array Transformation II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[0,10]", "[[0,1,2],[0,0,2],[0,1,2],[1,1,4],[0,1,3],[1,1,4],[0,1,2],[0,1,2],[0,1,2],[0,0,2],[1,1,2],[0,0,2],[0,0,3],[1,1,3],[0,0,5]]", 5)]
    [TestCase("[4,3,2,1]", "[[1,3,2],[0,2,1]]", -1)]
    [TestCase("[0,0,0]", "[[0,2,1],[0,2,1],[1,1,3]]", 0)]
    [TestCase("[2,0,2]", "[[0,2,1],[0,2,1],[1,1,3]]", 2)]
    [TestCase("[2,7,6,8,6,1,6,5,3,1]", "[[0,4,1],[2,7,2],[4,9,3],[1,6,2],[0,5,4],[3,7,4],[1,3,1]]", 5)]
    [TestCase("[0,8]", "[[0,1,4],[0,1,1],[0,1,4],[0,1,1],[1,1,5],[0,1,2],[1,1,4],[0,1,1],[1,1,3],[0,0,2],[1,1,3],[1,1,2],[0,1,5],[1,1,2],[1,1,5]]", 3)]
    public void Test(string input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MinZeroArray(input1.ParseIntArray(), input2.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
