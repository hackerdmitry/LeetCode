using NUnit.Framework;

namespace LeetCode._1._Easy._202._Happy_Number;

[TestFixture(TestName = "202. Happy Number")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(19, true)]
    [TestCase(2, false)]
    public void Test(int input, bool output)
    {
        var solution = new Solution();
        var actual = solution.IsHappy(input);
        Assert.AreEqual(output, actual);
    }
}