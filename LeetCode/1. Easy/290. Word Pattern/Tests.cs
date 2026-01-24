using NUnit.Framework;

namespace LeetCode._1._Easy._290._Word_Pattern;

[TestFixture(TestName = "290. Word Pattern")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("abba", "dog cat cat dog", true)]
    [TestCase("abba", "dog cat cat fish", false)]
    [TestCase("aaaa", "dog cat cat dog", false)]
    public void Test(string input1, string input2, bool output)
    {
        var solution = new Solution();
        var actual = solution.WordPattern(input1, input2);
        Assert.AreEqual(output, actual);
    }
}