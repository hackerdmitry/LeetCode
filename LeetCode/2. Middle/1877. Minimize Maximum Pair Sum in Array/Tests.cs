using NUnit.Framework;

namespace LeetCode._2._Middle._1877._Minimize_Maximum_Pair_Sum_in_Array;

[TestFixture(TestName = "1877. Minimize Maximum Pair Sum in Array")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{3,5,2,3}, 7)]
    [TestCase(new[]{3,5,4,2,4,6}, 8)]
    [TestCase(new[]{3,3,2,3}, 6)]
    public void Test(int[] input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinPairSum(input);
        Assert.AreEqual(output, actual);
    }
}
