using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._209._Minimum_Size_Subarray_Sum;

[TestFixture(TestName = "209. Minimum Size Subarray Sum")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(213, "[12,28,83,4,25,26,25,2,25,25,25,12]", 8)]
    [TestCase(7, "[2,3,1,2,4,3]", 2)]
    [TestCase(4, "[1,4,4]", 1)]
    [TestCase(11, "[1,1,1,1,1,1,1,1]", 0)]
    public void Test(int input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MinSubArrayLen(input1, input2.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
