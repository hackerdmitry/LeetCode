using NUnit.Framework;

namespace LeetCode._2._Middle._560._Subarray_Sum_Equals_K;

[TestFixture(TestName = "560. Subarray Sum Equals K")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{1,1,1}, 2, 2)]
    [TestCase(new[]{1,2,3}, 3, 2)]
    [TestCase(new[]{1,1,1,1,1}, 3, 3)]
    [TestCase(new[]{1,-1,0}, 0, 3)]
    [TestCase(new[]{0,0}, 0, 3)]
    public void Test(int[] input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.SubarraySum(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
