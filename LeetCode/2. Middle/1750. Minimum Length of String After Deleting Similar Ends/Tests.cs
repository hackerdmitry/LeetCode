using NUnit.Framework;

namespace LeetCode._2._Middle._1750._Minimum_Length_of_String_After_Deleting_Similar_Ends;

[TestFixture(TestName = "1750. Minimum Length of String After Deleting Similar Ends")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("ca", 2)]
    [TestCase("cabaabac", 0)]
    [TestCase("aabccabba", 3)]
    [TestCase("a", 1)]
    [TestCase("aaa", 0)]
    [TestCase("bbbbbbbbbbbbbbbbbbbbbbbbbbbabbbbbbbbbbbbbbbccbcbcbccbbabbb", 1)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinimumLength(input);
        Assert.AreEqual(output, actual);
    }
}
