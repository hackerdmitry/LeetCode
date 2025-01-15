using NUnit.Framework;

namespace LeetCode._2._Middle._2429._Minimize_XOR;

[TestFixture(TestName = "2429. Minimize XOR")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(25, 72, 24)]
    [TestCase(12, 1, 8)]
    [TestCase(3, 5, 3)]
    [TestCase(1, 12, 3)]
    public void Test(int input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MinimizeXor(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
