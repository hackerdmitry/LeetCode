using NUnit.Framework;

namespace LeetCode._1._Easy._1422._Maximum_Score_After_Splitting_a_String;

[TestFixture(TestName = "1422. Maximum Score After Splitting a String")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("011101", 5)]
    [TestCase("00111", 5)]
    [TestCase("1111", 3)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxScore(input);
        Assert.AreEqual(output, actual);
    }
}
