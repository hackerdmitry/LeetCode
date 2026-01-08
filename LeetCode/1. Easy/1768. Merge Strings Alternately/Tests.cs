using NUnit.Framework;

namespace LeetCode._1._Easy._1768._Merge_Strings_Alternately;

[TestFixture(TestName = "1768. Merge Strings Alternately")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("abc", "pqr", "apbqcr")]
    [TestCase("ab", "pqrs", "apbqrs")]
    [TestCase("abcd", "pq", "apbqcd")]
    public void Test(string input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.MergeAlternately(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
