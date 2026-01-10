using NUnit.Framework;

namespace LeetCode._1._Easy._392._Is_Subsequence;

[TestFixture(TestName = "392. Is Subsequence")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("abc", "ahbgdc", true)]
    [TestCase("axc", "ahbgdc", false)]
    public void Test(string input1, string input2, bool output)
    {
        var solution = new Solution();
        var actual = solution.IsSubsequence(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
