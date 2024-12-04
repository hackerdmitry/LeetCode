using NUnit.Framework;

namespace LeetCode._2._Middle._2825._Make_String_a_Subsequence_Using_Cyclic_Increments;

[TestFixture(TestName = "2825. Make String a Subsequence Using Cyclic Increments")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("eao", "ofa", false)]
    [TestCase("ab", "bb", true)]
    [TestCase("abc", "ad", true)]
    [TestCase("zc", "ad", true)]
    [TestCase("ab", "d", false)]
    public void Test(string input1, string input2, bool output)
    {
        var solution = new Solution();
        var actual = solution.CanMakeSubsequence(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
