using NUnit.Framework;

namespace LeetCode._2._Middle._50._Pow_x__n_;

[TestFixture(TestName = "50. Pow(x, n)")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(2.00000, 10, 1024.00000)]
    [TestCase(2.10000, 3, 9.26100)]
    [TestCase(2.00000, -2, 0.25000)]
    public void Test(double input1, int input2, double output)
    {
        var solution = new Solution();
        var actual = solution.MyPow(input1, input2);
        Assert.AreEqual(output, actual, 1e-5);
    }
}