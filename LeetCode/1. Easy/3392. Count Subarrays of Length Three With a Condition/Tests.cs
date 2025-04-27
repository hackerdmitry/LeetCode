using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._3392._Count_Subarrays_of_Length_Three_With_a_Condition;

[TestFixture(TestName = "3392. Count Subarrays of Length Three With a Condition")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,1,4,1]", 1)]
    [TestCase("[1,1,1]", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.CountSubarrays(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}