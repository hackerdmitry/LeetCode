using NUnit.Framework;

namespace LeetCode._2._Middle._300._Longest_Increasing_Subsequence;

[TestFixture(TestName = "300. Longest Increasing Subsequence")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{10,9,2,5,3,7,101,18}, 4)]
    [TestCase(new[]{0,1,0,3,2,3}, 4)]
    [TestCase(new[]{7,7,7,7,7,7,7}, 1)]
    public void Test(int[] input, int output)
    {
        var solution = new Solution();
        var actual = solution.LengthOfLIS(input);
        Assert.AreEqual(output, actual);
    }
}
