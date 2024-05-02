using NUnit.Framework;

namespace LeetCode._1._Easy._2441._Largest_Positive_Integer_That_Exists_With_Its_Negative;

[TestFixture(TestName = "2441. Largest Positive Integer That Exists With Its Negative")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{-1,2,-3,3}, 3)]
    [TestCase(new[]{-1,10,6,7,-7,1}, 7)]
    [TestCase(new[]{-10,8,6,7,-2,-3}, -1)]
    [TestCase(new[]{1}, -1)]
    [TestCase(new[]{1,2,3}, -1)]
    public void Test(int[] input, int output)
    {
        var solution = new Solution();
        var actual = solution.FindMaxK(input);
        Assert.AreEqual(output, actual);
    }
}
