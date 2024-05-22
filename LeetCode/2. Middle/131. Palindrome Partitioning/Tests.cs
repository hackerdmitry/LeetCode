using System.Collections.Generic;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._131._Palindrome_Partitioning;

[TestFixture(TestName = "131. Palindrome Partitioning")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("aab", "[[\"a\",\"a\",\"b\"],[\"aa\",\"b\"]]")]
    [TestCase("aab", "[[\"a\",\"a\",\"b\"],[\"aa\",\"b\"]]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.Partition(input);
        var expected = output.ParseStringArray2d();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
