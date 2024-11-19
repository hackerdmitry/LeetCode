using System.Linq;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2461._Maximum_Sum_of_Distinct_Subarrays_With_Length_K;

[TestFixture(TestName = "2461. Maximum Sum of Distinct Subarrays With Length K")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[9,9,9,1,2,3]", 3, 12)]
    [TestCase("[1,5,4,2,9,9,9]", 3, 15)]
    [TestCase("[4,4,4]", 3, 0)]
    public void Test(string input1, int input2, long output)
    {
        var solution = new Solution();
        var actual = solution.MaximumSubarraySum(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }

    [Timeout(1000)]
    [Test]
    public void BigTest()
    {
        var nums = Enumerable.Range(1, 10_000).ToArray();
        var k = 10_000;

        var actual = new Solution().MaximumSubarraySum(nums, k);
        var expected = 10_001L * 5_000;

        Assert.AreEqual(expected, actual);
    }
}
