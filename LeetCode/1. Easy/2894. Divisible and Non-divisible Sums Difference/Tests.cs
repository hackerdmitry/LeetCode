using NUnit.Framework;

namespace LeetCode._1._Easy._2894._Divisible_and_Non_divisible_Sums_Difference;

[TestFixture(TestName = "2894. Divisible and Non-divisible Sums Difference")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(10, 3, 19)]
    [TestCase(5, 6, 15)]
    [TestCase(5, 1, -15)]
    public void Test(int input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.DifferenceOfSums(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
