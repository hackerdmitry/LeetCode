using NUnit.Framework;

namespace LeetCode._2._Middle._1717._Maximum_Score_From_Removing_Substrings;

[TestFixture(TestName = "1717. Maximum Score From Removing Substrings")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("cdbcbbaaabab", 4, 5, 19)]
    [TestCase("aabbaaxybbaabb", 5, 4, 20)]
    [TestCase("bbaaab", 4, 5, 14)]
    [TestCase("bbaaab", 5, 4, 13)]
    public void Test(string input1, int input2, int input3, int output)
    {
        var solution = new Solution();
        var actual = solution.MaximumGain(input1, input2, input3);
        Assert.AreEqual(output, actual);
    }
}
