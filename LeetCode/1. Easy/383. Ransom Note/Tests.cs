using NUnit.Framework;

namespace LeetCode._1._Easy._383._Ransom_Note;

[TestFixture(TestName = "383. Ransom Note")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("a", "b", false)]
    [TestCase("aa", "ab", false)]
    [TestCase("aa", "aab", true)]
    public void Test(string input1, string input2, bool output)
    {
        var solution = new Solution();
        var actual = solution.CanConstruct(input1, input2);
        Assert.AreEqual(output, actual);
    }
}