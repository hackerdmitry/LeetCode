using NUnit.Framework;

namespace LeetCode._1._Easy._345._Reverse_Vowels_of_a_String;

[TestFixture(TestName = "345. Reverse Vowels of a String")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("IceCreAm", "AceCreIm")]
    [TestCase("leetcode", "leotcede")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.ReverseVowels(input);
        Assert.AreEqual(output, actual);
    }
}
