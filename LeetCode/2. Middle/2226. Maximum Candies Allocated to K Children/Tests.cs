using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2226._Maximum_Candies_Allocated_to_K_Children;

// ⭐
[TestFixture(TestName = "2226. Maximum Candies Allocated to K Children")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[5,8,6]", 3, 5)]
    [TestCase("[2,5]", 11, 0)]
    public void Test(string input1, long input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MaximumCandies(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
