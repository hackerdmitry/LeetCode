using NUnit.Framework;

namespace LeetCode._1._Easy._3813._Vowel_Consonant_Score;

[TestFixture(TestName = "3813. Vowel-Consonant Score")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("cooear", 2)]
    [TestCase("axeyizou", 1)]
    [TestCase("au 123", 0)]
    [TestCase("i3", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.VowelConsonantScore(input);
        Assert.AreEqual(output, actual);
    }
}
