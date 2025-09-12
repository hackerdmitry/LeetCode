using NUnit.Framework;

namespace LeetCode._2._Middle._3227._Vowels_Game_in_a_String;

[TestFixture(TestName = "3227. Vowels Game in a String")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("leetcoder", true)]
    [TestCase("bbcd", false)]
    public void Test(string input, bool output)
    {
        var solution = new Solution();
        var actual = solution.DoesAliceWin(input);
        Assert.AreEqual(output, actual);
    }
}
