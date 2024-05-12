using NUnit.Framework;

namespace LeetCode._2._Middle._7._Reverse_Integer;

[TestFixture(TestName = "7. Reverse Integer")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(123, 321)]
    [TestCase(-123, -321)]
    [TestCase(120, 21)]
    [TestCase(1534236469, 0)]
    public void Test(int input, int output)
    {
        var solution = new Solution();
        var actual = solution.Reverse(input);
        Assert.AreEqual(output, actual);
    }
}