using NUnit.Framework;

namespace LeetCode._1._Easy._3330._Find_the_Original_Typed_String_I;

[TestFixture(TestName = "3330. Find the Original Typed String I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("abbcccc", 5)]
    [TestCase("abcd", 1)]
    [TestCase("aaaa", 4)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.PossibleStringCount(input);
        Assert.AreEqual(output, actual);
    }
}
