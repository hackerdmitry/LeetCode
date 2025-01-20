using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2661._First_Completely_Painted_Row_or_Column;

[TestFixture(TestName = "2661. First Completely Painted Row or Column")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,3,4,2]", "[[1,4],[2,3]]", 2)]
    [TestCase("[2,8,7,4,1,3,5,6,9]", "[[3,2,5],[1,4,6],[8,7,9]]", 3)]
    public void Test(string input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.FirstCompleteIndex(input1.ParseIntArray(), input2.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
