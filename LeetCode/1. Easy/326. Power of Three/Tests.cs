using NUnit.Framework;

namespace LeetCode._1._Easy._326._Power_of_Three;

[TestFixture(TestName = "326. Power of Three")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(0, false)]
    [TestCase(27, true)]
    [TestCase(-1, false)]
    [TestCase(90, false)]
    public void Test(int input, bool output)
    {
        var solution = new Solution();
        var actual = solution.IsPowerOfThree(input);
        Assert.AreEqual(output, actual);
    }
}
