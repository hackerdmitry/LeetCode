using NUnit.Framework;

namespace LeetCode._2._Middle._3223._Minimum_Length_of_String_After_Operations;

[TestFixture(TestName = "3223. Minimum Length of String After Operations")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("abaacbcbb", 5)]
    [TestCase("aa", 2)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinimumLength(input);
        Assert.AreEqual(output, actual);
    }
}
