using NUnit.Framework;

namespace LeetCode._1._Easy._263._Ugly_Number;

[TestFixture(TestName = "263. Ugly Number")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(6, true)]
    [TestCase(1, true)]
    [TestCase(14, false)]
    [TestCase(-2147483648, false)]
    public void Test(int input, bool output)
    {
        var solution = new Solution();
        var actual = solution.IsUgly(input);
        Assert.AreEqual(output, actual);
    }
}
