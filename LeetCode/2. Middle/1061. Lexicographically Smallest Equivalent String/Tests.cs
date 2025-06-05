using NUnit.Framework;

namespace LeetCode._2._Middle._1061._Lexicographically_Smallest_Equivalent_String;

[TestFixture(TestName = "1061. Lexicographically Smallest Equivalent String")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("abc", "cde", "eed", "aab")]
    [TestCase("parker", "morris", "parser", "makkek")]
    [TestCase("hello", "world", "hold", "hdld")]
    [TestCase("leetcode", "programs", "sourcecode", "aauaaaaada")]
    public void Test(string input1, string input2, string input3, string output)
    {
        var solution = new Solution();
        var actual = solution.SmallestEquivalentString(input1, input2, input3);
        Assert.AreEqual(output, actual);
    }
}