using NUnit.Framework;

namespace LeetCode._1._Easy._3136._Valid_Word;

[TestFixture(TestName = "3136. Valid Word")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("234Adas", true)]
    [TestCase("b3", false)]
    [TestCase("a3$e", false)]
    public void Test(string input, bool output)
    {
        var solution = new Solution();
        var actual = solution.IsValid(input);
        Assert.AreEqual(output, actual);
    }
}
