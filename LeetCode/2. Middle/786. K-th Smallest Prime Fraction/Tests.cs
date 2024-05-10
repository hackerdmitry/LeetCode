using NUnit.Framework;

namespace LeetCode._2._Middle._786._K_th_Smallest_Prime_Fraction;

[TestFixture(TestName = "786. K-th Smallest Prime Fraction")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[] {1, 2, 3, 5}, 3, new[] {2, 5})]
    [TestCase(new[] {1, 7}, 1, new[] {1, 7})]
    public void Test(int[] input1, int input2, int[] output)
    {
        var solution = new Solution();
        var actual = solution.KthSmallestPrimeFraction(input1, input2);
        Assert.AreEqual(output, actual);
    }
}