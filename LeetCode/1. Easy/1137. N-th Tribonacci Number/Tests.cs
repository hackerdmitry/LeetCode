using NUnit.Framework;

namespace LeetCode._1._Easy._1137._N_th_Tribonacci_Number;

[TestFixture(TestName = "1137. N-th Tribonacci Number")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(4, 4)]
    [TestCase(25, 1389537)]
    public void Test(int input, int output)
    {
        var solution = new Solution();
        var actual = solution.Tribonacci(input);
        Assert.AreEqual(output, actual);
    }
}
