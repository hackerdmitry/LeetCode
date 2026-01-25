using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1984._Minimum_Difference_Between_Highest_and_Lowest_of_K_Scores;

[TestFixture(TestName = "1984. Minimum Difference Between Highest and Lowest of K Scores")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[90]", 1, 0)]
    [TestCase("[9,4,1,7]", 2, 2)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MinimumDifference(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
