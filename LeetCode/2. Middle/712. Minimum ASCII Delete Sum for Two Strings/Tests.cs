using NUnit.Framework;

namespace LeetCode._2._Middle._712._Minimum_ASCII_Delete_Sum_for_Two_Strings;

[TestFixture(TestName = "712. Minimum ASCII Delete Sum for Two Strings")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("sea", "eat", 231)]
    [TestCase("delete", "leet", 403)]
    [TestCase("vsmfbgotim", "xibcpmzyikel", 1965)]
    [TestCase("ee", "eee", 101)]
    [TestCase("eee", "ee", 101)]
    public void Test(string input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MinimumDeleteSum(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
