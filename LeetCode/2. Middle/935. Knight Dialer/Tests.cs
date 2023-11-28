using NUnit.Framework;

namespace LeetCode._2._Middle._935._Knight_Dialer;

[TestFixture(TestName = "935. Knight Dialer")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(1, 10)]
    [TestCase(2, 20)]
    [TestCase(3131, 136006598)]
    public void Test(int input, int output)
    {
        var solution = new Solution();
        var actual = solution.KnightDialer(input);
        Assert.AreEqual(output, actual);
    }
}
