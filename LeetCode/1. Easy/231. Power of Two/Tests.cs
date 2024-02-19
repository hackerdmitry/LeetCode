using NUnit.Framework;

namespace LeetCode._1._Easy._231._Power_of_Two;

[TestFixture(TestName = "231. Power of Two")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(1, true)]
    [TestCase(16, true)]
    [TestCase(3, false)]
    [TestCase(0, false)]
    [TestCase(1 << 30, true)]
    public void Test(int input, bool output)
    {
        var solution = new Solution();
        var actual = solution.IsPowerOfTwo(input);
        Assert.AreEqual(output, actual);
    }
}