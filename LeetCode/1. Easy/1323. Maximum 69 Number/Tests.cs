using NUnit.Framework;

namespace LeetCode._1._Easy._1323._Maximum_69_Number;

[TestFixture(TestName = "1323. Maximum 69 Number")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(9669, 9969)]
    [TestCase(9996, 9999)]
    [TestCase(9999, 9999)]
    public void Test(int input, int output)
    {
        var solution = new Solution();
        var actual = solution.Maximum69Number(input);
        Assert.AreEqual(output, actual);
    }
}
