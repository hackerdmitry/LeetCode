using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3350._Adjacent_Increasing_Subarrays_Detection_II;

[TestFixture(TestName = "3350. Adjacent Increasing Subarrays Detection II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,5,7,8,9,2,3,4,3,1]", 3)]
    [TestCase("[1,2,3,4,4,4,4,5,6,7]", 2)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxIncreasingSubarrays(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
